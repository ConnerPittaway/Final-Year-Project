using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPressureWall : MonoBehaviour
{
    public bool isActive;

    private void Start()
    {
        isActive = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<SpriteRenderer>().color.a > 0.51)
        {
            isActive = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<SpriteRenderer>().color.a > 0.51)
        {
            isActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isActive = false;
    }
}
