using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class FireThrow90 : MonoBehaviour
{
    VisualEffect VFX;
    void Start()
    {
        VFX = GetComponent<VisualEffect>();

        InvokeRepeating("StopEffect", 5f, 10f);
        InvokeRepeating("PlayEffect", 0f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void StopEffect()
    {
        VFX.Stop();
    }

    void PlayEffect()
    {
        VFX.Play();
    }
}
