using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class movement : MonoBehaviour
{

    public float movementSpeed = 0.6f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movementVector;

    // Update is called once per frame
    void Update()
    {
        if (EventSystem.current.currentSelectedGameObject != null)
        {
            if(EventSystem.current.currentSelectedGameObject.GetComponent<TMPro.TMP_InputField>() != null)
            {
                movementVector.x = 0;
                movementVector.y = 0;
                animator.SetFloat("Horizontal", movementVector.x);
                animator.SetFloat("Vertical", movementVector.y);
                animator.SetFloat("Speed", movementVector.sqrMagnitude);
                return;
            }
        }

        movementVector.x = Input.GetAxis("Horizontal");
        movementVector.y = Input.GetAxis("Vertical");

        animator.SetFloat("Horizontal", movementVector.x);
        animator.SetFloat("Vertical", movementVector.y);
        animator.SetFloat("Speed", movementVector.sqrMagnitude);
    }

    void FixedUpdate()
    {
        if (EventSystem.current.currentSelectedGameObject != null)
        {
            if (EventSystem.current.currentSelectedGameObject.GetComponent<TMPro.TMP_InputField>() != null)
            {
                movementVector.x = 0;
                movementVector.y = 0;
                animator.SetFloat("Horizontal", movementVector.x);
                animator.SetFloat("Vertical", movementVector.y);
                animator.SetFloat("Speed", movementVector.sqrMagnitude);
                return;
            }
        }
        rb.MovePosition(rb.position + movementVector * movementSpeed * Time.fixedDeltaTime);
    }
}
