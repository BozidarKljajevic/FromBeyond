using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    private bool colision = false;
    private bool hasSkull;
    public GameObject foundSkull;
    public GameObject platforms;
    public GameObject skull;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Third Person Player" && other.GetComponent<PlayerMove>().hasSkull)
        {
            foundSkull.SetActive(true);
            hasSkull = other.GetComponent<PlayerMove>().hasSkull;
            colision = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            foundSkull.SetActive(false);
            colision = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (colision && hasSkull) 
        {
            
            UiManager uiManager = GameObject.Find("Canvas").GetComponent<UiManager>();

            skull.SetActive(true);

            if (uiManager != null)
            {
                uiManager.ThrowOutSkull();
            }

            platforms.SetActive(true);
        }
    }
}
