using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowingUp : MonoBehaviour
{
    private bool activ;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            Debug.Log("Kontakt ostvaren");
            activ = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            activ = false;
        }
    }

    private void Update()
    {
        this.GetComponent<Renderer>().enabled = activ;
    }
}
