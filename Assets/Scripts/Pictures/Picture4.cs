using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture4 : MonoBehaviour
{
    private bool collision = false;
    public GameObject picture;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            collision = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            collision = false;
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (collision && Input.GetKey(KeyCode.T))
        {
            picture.SetActive(true);
            Time.timeScale = 0f;
        }


    }
}
