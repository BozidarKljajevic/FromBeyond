using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private float nextActionTime = 0.0f;
    public float period = 0.01f;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {

            other.GetComponent<PlayerHealth>().TakeDamage(0.05f);
            /*if (Time.time > nextActionTime)
            {
                Debug.Log("Vreme je " + Time.time);
                nextActionTime = Time.time + period;

                other.GetComponent<PlayerHealth>().TakeDamage(2);
            }*/
        }
    }
}
