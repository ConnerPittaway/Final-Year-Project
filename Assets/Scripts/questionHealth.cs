using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questionHealth : MonoBehaviour
{
    public Slider slider;
    public Color low;
    public Color high;

    //Health Stuff
    public float internalHealth = 10.0f;
    private float internalMaxHealth = 10.0f;

    public GameObject deathScreen;

    void Start()
    {
        SetHealth(internalHealth, internalMaxHealth);
    }

    public void SetHealth(float health, float maxHealth)
    {
        slider.maxValue = maxHealth;
        slider.value = health;
        slider.fillRect.GetComponent<Image>().color = Color.Lerp(low, high, slider.normalizedValue);
    }

    public void takeDamage(float damage)
    {
        Audio.Instance.PlaySFX("Lightning");
        internalHealth -= damage;
        SetHealth(internalHealth, internalMaxHealth);
        if (internalHealth <= 0)
        {
            Audio.Instance.PlaySFX("Player Death");
            deathScreen.SetActive(true);
        }
    }

    public float getHealth()
    {
        return internalHealth;
    }
}
