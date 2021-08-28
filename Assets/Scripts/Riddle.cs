using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riddle : MonoBehaviour
{
    private bool rotation1, rotation2 = false;
    private Vector3 angleToRotate;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            Debug.Log("Kolizija");
            rotation1 = true;
            StartCoroutine(WaitForHalfASecond());
            if (rotation1){
                angleToRotate = new Vector3(0, 0, 180);
                this.transform.Rotate(new Vector3(0f, 0f, 0.2f), angleToRotate.z * Time.deltaTime / 10, Space.Self);
                
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            Debug.Log("Nije Kolizija");
            rotation2 = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    IEnumerator WaitForHalfASecond()
    {
        yield return new WaitForSeconds(5f);
        rotation1 = false;
    }

}
