using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public HealthBarBehaviour healthBar;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        healthBar.SetHealth(health, maxHealth);
    }

    public void playerTakeDamage(float damage)
    {
        health -= damage;
        healthBar.SetHealth(health, maxHealth);

        if (health <= 0)
        {
            (gameObject).SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
