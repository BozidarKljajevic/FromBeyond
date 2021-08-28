using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatformLevel2 : MonoBehaviour
{
    private bool falling = false;
    private float downSpeed = 0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            falling = true;

            Destroy(gameObject, 2);
        }
    }

    private void Update()
    {
        if (falling)
        {
            downSpeed += Time.deltaTime/65;
            transform.position = new Vector3(transform.position.x, transform.position.y - downSpeed, transform.position.z);
        }
    }
}
