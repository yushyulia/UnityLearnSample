using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjects : SampleScript
{
    public GameObject prefab;
    private int count = 4;
    private Vector3 distance = new Vector3(3, 0, 0);
    [ContextMenu("Use")]
    public override void Use()
    {
        for (int i = 0; i < count; i++)
        {
            CreateObjs();
        }
    }
    private void CreateObjs()
    {

        Instantiate(prefab, transform.position + distance, Quaternion.identity, transform);
        distance += new Vector3(3, 0, 0);

    }
}
