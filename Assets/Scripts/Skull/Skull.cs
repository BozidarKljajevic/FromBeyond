using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull : MonoBehaviour
{
    private bool colision = false;
    PlayerMove player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            player = other.GetComponent<PlayerMove>();
            colision = true;


        }
    }

    private void Update()
    {
        Vector3 rotateVector = new Vector3(0, 0.2f, 0);
        transform.Rotate(rotateVector);

        if (colision = true && Input.GetKeyDown(KeyCode.T))
        {
            if (player != null)
            {
                player.hasSkull = true;
                UiManager uiManager = GameObject.Find("Canvas").GetComponent<UiManager>();

                if (uiManager != null)
                {
                    uiManager.CollectedSkull();
                }

                Destroy(this.gameObject);
            }
        }
    }
}
