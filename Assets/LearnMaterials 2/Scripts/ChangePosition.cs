using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : SampleScript
{
    private bool check;
    public Transform obj;
    private Vector3 second = new Vector3(3, 0, 0);
    private float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        if (check)
        {
            Moving();
        }
        
    }

    public override void Use()
    {
        check = true;
    }

    private void Moving()
    {
        obj.position = Vector3.MoveTowards(obj.position, second, Time.deltaTime * speed);
    }
}
