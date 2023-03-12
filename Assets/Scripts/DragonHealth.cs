using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragonHealth : MonoBehaviour
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

    public void dragonTakeDamage(float damage)
    {
        health -= damage;
        healthBar.SetHealth(health, maxHealth);

        if(health <= 0)
        {
            Audio.Instance.PlaySFX("Dragon Death");
            (gameObject).SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
