using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowingUpMajority : MonoBehaviour
{
    public GameObject nextPlat, prevPlat, disPlat;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            Debug.Log("Kontakt postoji");
            //this.gameObject.SetActive(true);
            prevPlat.SetActive(true);
            nextPlat.SetActive(true);
            disPlat.SetActive(false);
            
        }
    }

    /*private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            //this.gameObject.SetActive(false);
            disPlat.SetActive(false);
        }
    }*/
}
