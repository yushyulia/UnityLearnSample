using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : SampleScript
{
    private bool check;
    public Transform obj;
    private float y = 90f;
    private float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        if (check)
        {
            ChangeRotation();
        }
    }

    public override void Use()
    {
        check = !check;
    }

    public void ChangeRotation()
    {
        y += Time.deltaTime * speed;
        obj.rotation = Quaternion.Euler(0, y, 0);
    }

}
