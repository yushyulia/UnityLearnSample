using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : SampleScript
{
    [SerializeField]
    private List<SampleScript> samples;

    [ContextMenu("Μενώ")]
    public override void Use()
    {
        foreach(SampleScript sample in samples)
        {
            sample.Use();
        }
    }

}
