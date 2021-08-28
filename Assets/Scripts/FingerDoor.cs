using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerDoor : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            this.GetComponent<Renderer>().enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            this.GetComponent<Renderer>().enabled = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
