using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // Start is called before the first frame update

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
        Vector3 rotateVector = new Vector3(0.5f, 0, 0);
        transform.Rotate(rotateVector);

        if (colision=true && Input.GetKeyDown(KeyCode.I))
        {
            if (player != null)
            {
                player.hasKey = true;
                UiManager uiManager = GameObject.Find("Canvas").GetComponent<UiManager>();

                if(uiManager != null)
                {
                    uiManager.CollectedKey();
                }

                Destroy(this.gameObject);
            }
        }
    }
}
