using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : SampleScript
{
    public Transform obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeRotation();
    }

    public override void Use()
    {

    }

    private float y = 90f;
    private float speed = 10f;
    public void ChangeRotation()
    {
        y += Time.deltaTime * speed;
        obj.rotation = Quaternion.Euler(0, y, 0);
    }

}
