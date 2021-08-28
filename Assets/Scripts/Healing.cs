using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            Debug.Log("U kontaktu sa healom");

            other.GetComponent<PlayerHealth>().Healing(0.05f);


        }
    }
}
