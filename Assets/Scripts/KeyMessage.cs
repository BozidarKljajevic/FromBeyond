using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMessage : MonoBehaviour
{

    public GameObject keyMessage;
    private bool hasKey;
    public GameObject door;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            hasKey = other.GetComponent<PlayerMove>().hasKey;
            if (!hasKey)
            {
                keyMessage.SetActive(true);
            }
            else 
            {
                Destroy(door);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
             keyMessage.SetActive(false);
        }
    }
}
