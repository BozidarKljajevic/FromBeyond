using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class FireThrow : MonoBehaviour
{
    // Start is called before the first frame update
    VisualEffect VFX;
    void Start()
    {
        VFX = GetComponent<VisualEffect>();

        InvokeRepeating("StopEffect", 0f, 10f);
        InvokeRepeating("PlayEffect", 5f, 10f);
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
