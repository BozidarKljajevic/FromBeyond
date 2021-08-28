using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartLife : MonoBehaviour
{
    PlayerMove player;
    public bool collision = false;
    public GameObject extraHeart, secondHeart;
    public GameObject deathZone;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            player = other.GetComponent<PlayerMove>();
            collision = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotateVector = new Vector3(0, 0.5f, 0);
        transform.Rotate(rotateVector);

        if (collision = true && Input.GetKeyDown(KeyCode.E))
        {
            if (player != null)
            {
                if(secondHeart.active == true) 
                {
                    player.hasExtraLife = true;
                    extraHeart.SetActive(true);
                    Destroy(this.gameObject);
                }
                else
                {
                    secondHeart.SetActive(true);
                    Destroy(this.gameObject);
                }
                deathZone.GetComponent<DeathZone>().lifes++;
            }
        }
    }
}
