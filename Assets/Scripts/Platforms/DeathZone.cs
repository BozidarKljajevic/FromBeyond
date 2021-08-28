using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    [SerializeField]
    public GameObject raspwanPoint;
    public int lifes = 2;
    public GameObject heart2, heart3;
    public GameObject healthBar;
    private float sliderValue;
    PlayerMove player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Third Person Player")
        {
            player = other.GetComponent<PlayerMove>();

            lifes--;
            if (lifes == 0)
            {
                SceneManager.LoadScene("Menu");
            }
            other.transform.position = raspwanPoint.transform.position;
            //healthBar.GetComponent<Slider>().value = 100;

            if (heart3.active == true)
            {
                heart3.SetActive(false);
            }
            else 
            {
                heart2.SetActive(false);
            }  
        }
    }

    private void Update()
    {
        sliderValue = healthBar.GetComponent<Slider>().value;

        if (sliderValue <= 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
