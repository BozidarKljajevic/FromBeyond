using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour
{
    private bool lever = false;
    public Animator anim;
    public GameObject fallingPlatform1;
    public GameObject fallingPlatform2;
    public GameObject movingUpPlatform;
    [SerializeField]
    private Transform movingPlatStart;
    private float _speed = 1.0f;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            lever = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            lever = false;
        }
    }

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lever && Input.GetKey(KeyCode.T))
        {
            

            //fallingPlatform1.transform.position = Vector3.MoveTowards(fallingPlatform1.transform.position, falling1Position, _speed * Time.deltaTime);
            //movingUpPlatform.transform.position = movingPlatStart.position;
            Debug.Log("VEKTORE PROSAO");
            MovePlatform();
            Debug.Log("Pritisni ga burazeru");
            anim.enabled = true;
            StartCoroutine(WaitForHalfASecond());

        }
    }

    IEnumerator WaitForHalfASecond()
    {
        yield return new WaitForSeconds(5f);
        anim.enabled = false;
    }

    public void MovePlatform()
    {
        Vector3 startPosition1 = new Vector3(-0.913f, 7.942f, -2.42f);
        Vector3 startPosition2 = new Vector3(-0.913f, 7.942f, -5.22f);
        movingUpPlatform.transform.position = Vector3.MoveTowards(movingUpPlatform.transform.position, movingPlatStart.position, _speed * Time.deltaTime);
        fallingPlatform1.transform.position = Vector3.MoveTowards(fallingPlatform1.transform.position, startPosition1, _speed * Time.deltaTime);
        fallingPlatform2.transform.position = Vector3.MoveTowards(fallingPlatform2.transform.position, startPosition2, _speed * Time.deltaTime);


    }
}
