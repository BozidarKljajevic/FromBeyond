using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPassword : MonoBehaviour
{
    public GameObject correctPsssword;
    public bool openDoor;

    private void Start()
    {
       
    }

    private void Update()
    {
        openDoor = correctPsssword.GetComponent<ButtonGreen>().openDoor;
        Debug.Log(openDoor + "Ovo je potvrda vrata");
        if (openDoor)
        {
            Destroy(this.gameObject);
        }
    }
}
