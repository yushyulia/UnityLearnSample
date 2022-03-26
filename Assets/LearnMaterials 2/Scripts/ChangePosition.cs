using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : SampleScript
{
    public Transform obj;
    private Vector3 second = new Vector3(3, 0, 0);
    private float speed = 1f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Moving();
    }


    [SerializeField]
    public override void Use()
    {
        Start();
    }

    private void Moving()
    {
        obj.position = Vector3.MoveTowards(obj.position, second, Time.deltaTime * speed);
    }
}
