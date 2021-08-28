using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    bool isTime = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Enable());
    }

    // Update is called once per frame
    void Update()
    {
        if (isTime)
        {
            this.gameObject.GetComponent<Animator>().enabled = true;
            StartCoroutine(Disable());
            
        }
        
        //this.gameObject.GetComponent<Animator>().enabled = false;
        Vector3 cameraPosition = new Vector3(17f, -11f, -9f);
        this.gameObject.GetComponent<Transform>().position = cameraPosition;
    }

    IEnumerator Enable()
    {
        yield return new WaitForSeconds(15f);
        isTime = true;
    }

    IEnumerator Disable()
    {
        yield return new WaitForSeconds(1.5f);
        this.gameObject.GetComponent<Animator>().enabled = false;
        isTime = false;
    }
}
