using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth((int) maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            TakeDamage(20);
            Debug.Log("Trenutno helta" + healthBar.GetComponent<Slider>().value);
        }
    }

    public void TakeDamage(float dmg)
    {
        currentHealth -= dmg;
        healthBar.SetHealth((int) currentHealth);
    }

    public void Healing(float heal)
    {
        if(currentHealth + heal < 100)
        {
            currentHealth += heal;
        }
        
        healthBar.SetHealth((int) currentHealth);
    }
}
