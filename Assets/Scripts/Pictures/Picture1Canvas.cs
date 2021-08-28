using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture1Canvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.active)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                this.gameObject.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }
}
