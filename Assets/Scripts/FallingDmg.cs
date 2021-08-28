using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingDmg : MonoBehaviour
{
    public Vector3 enterPos;
    public Vector3 exitPos;

    private bool floor = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name != "Floor")
        {
            exitPos = transform.position;
        }
        else
        {
            enterPos = transform.position;

            if (exitPos.y - enterPos.y > 2)
            {
                Debug.Log("Treba demidzati");
                this.GetComponent<PlayerHealth>().TakeDamage(10);
            }
        }
    }
}
