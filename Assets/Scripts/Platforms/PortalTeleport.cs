using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleport : MonoBehaviour
{
    public Transform player;
    public Transform teleport;

    private bool readyToTeleport = false;
    // Update is called once per frame
    void Update()
    {
        if (readyToTeleport)
        {
            Vector3 playerToPortal = player.position - transform.position;
            float dotProduct = Vector3.Dot(transform.up, playerToPortal);

            //Debug.Log(dotProduct);
            //if(dotProduct < 0)
            //{
                float rotationDiff = -Quaternion.Angle(transform.rotation, teleport.rotation);
            Debug.Log(rotationDiff);
                rotationDiff += 180;
                player.Rotate(Vector3.up, rotationDiff);

                Vector3 positionOffset = Quaternion.Euler(0f, 0f, rotationDiff) * playerToPortal;
                player.transform.position = teleport.position + positionOffset;
                
                readyToTeleport = false;
            //}
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            Debug.Log("Treba da se teleprtuje");
            player.transform.position = teleport.transform.position;
            //readyToTeleport = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "Third Person Player")
        {
            readyToTeleport = false;
        }
    }
}
