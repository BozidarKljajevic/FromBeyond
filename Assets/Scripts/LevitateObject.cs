using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevitateObject : MonoBehaviour
{
    public bool move = false;
    public bool levitate = false;
    public GameObject Player;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Third Person Player")
        {
                move = true;
                this.transform.parent = Player.transform; 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
                move = false;
                this.transform.parent = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.R))
        {
            levitate = true;
            Debug.Log(levitate);
            //this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, this.transform.position.z);

        }

        levitate = false;
        Debug.Log(levitate);
    }
}
