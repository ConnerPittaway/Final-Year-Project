using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPressureMain : MonoBehaviour
{
    public bool isActive;

    private void Start()
    {
        isActive = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isActive = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isActive = false;
    }
}
