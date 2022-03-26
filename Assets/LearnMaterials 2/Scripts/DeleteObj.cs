using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObj : SampleScript
{
    public Transform target;
    private bool check;
    private Vector3 scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);
    [ContextMenu("Delete")]
    public override void Use()
    {
        check = true;
    }
    public void DeleteO()
    {
        target.localScale += scaleChange;
        var threshold = Vector3.one * 0.1f;
        if(target.localScale.x < threshold.x && 
            target.localScale.y < threshold.y && 
            target.localScale.z < threshold.z)
        {
            Destroy(target.gameObject);
            check = false;
        }
        
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (check) 
        { 
            DeleteO();
        }
        
    }
}
