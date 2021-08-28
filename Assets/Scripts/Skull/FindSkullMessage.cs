using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindSkullMessage : MonoBehaviour
{
    public GameObject skullMessage;
    public bool hasSkull;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            this.GetComponent<Animator>().SetBool("idle", true);
            hasSkull = other.GetComponent<PlayerMove>().hasSkull;
            if (!hasSkull)
            {
                skullMessage.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            skullMessage.SetActive(false);
        }
    }
}
