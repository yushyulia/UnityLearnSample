using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SampleScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Use();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public abstract void Use();
}
