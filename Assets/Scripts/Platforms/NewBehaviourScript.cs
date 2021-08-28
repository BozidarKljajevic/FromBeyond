using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private bool up = false;
    [SerializeField]
    private Transform _endPoint;
    private float _speed = 1.0f;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            Debug.Log("Sad mu je roditelj");
            other.transform.parent = this.transform;
            up = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            
            other.transform.parent = null;
            up = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (up)
        {
            transform.position = Vector3.MoveTowards(transform.position, _endPoint.position, _speed * Time.deltaTime);
        }
    }
}
