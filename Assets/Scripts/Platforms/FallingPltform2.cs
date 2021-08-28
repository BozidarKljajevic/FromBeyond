using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPltform2 : MonoBehaviour
{
    private bool falling = false;
    private float downSpeed = 2.5f;
    [SerializeField]
    private Transform _endPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            Debug.Log("U kontaktu su");
            falling = true;

        }
    }



    IEnumerator WaitForHalfASecond()
    {
        yield return new WaitForSeconds(4f);
        falling = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (falling)
        {
            transform.position = Vector3.MoveTowards(transform.position, _endPoint.position, downSpeed * Time.deltaTime);
            StartCoroutine(WaitForHalfASecond());
        }
    }
}
