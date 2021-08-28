using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Third Person Player")
        {
            Debug.Log("Unisti budalu");
            Destroy(collision.gameObject);
        }
    }
}
