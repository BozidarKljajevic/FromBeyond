using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField]
    private Transform _startPoint, _endPoint;
    private float _speed = 1.0f;
    private bool _switching = false;
    public GameObject Player;
    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!_switching)
        {
            transform.position = Vector3.MoveTowards(transform.position, _endPoint.position, _speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, _startPoint.position, _speed * Time.deltaTime);
        }

        if(transform.position == _endPoint.position)
        {
            _switching = true;
        }
        else if(transform.position == _startPoint.position)
        {
            _switching = false;
        }

    }

    private void OnTriggerEnter(Collider other)
   {
        if(other.gameObject == Player)
        {
            Player.transform.parent = this.transform;
            Debug.Log("Na platformiiiiiiii");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == Player)
        {
            Player.transform.parent = null;
            Debug.Log("Van paltformeeeee");
        }
    }
    

}
