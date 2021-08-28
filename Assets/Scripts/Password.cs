using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Password : MonoBehaviour
{
    private bool password = false;
    public GameObject keypad;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            password = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            password = false;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (password && Input.GetKey(KeyCode.T))
        {
            keypad.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}


