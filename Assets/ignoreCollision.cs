using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreCollision : MonoBehaviour
{
    public Collider2D playerCollider;
    public CompositeCollider2D wallCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check if opacity has been reset
        if (this.GetComponent<SpriteRenderer>().color.a >= 0.51)
        {
            Physics2D.IgnoreCollision(wallCollider, playerCollider, false);
        }
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("InnerWalls") && this.GetComponent<SpriteRenderer>().color.a <= 0.5)
        {
            Physics2D.IgnoreCollision(collision.collider, playerCollider, true);
        }
        else
        {
            Physics2D.IgnoreCollision(collision.collider, playerCollider, false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(this.GetComponent<SpriteRenderer>().color.a);
        if (collision.gameObject.CompareTag("InnerWalls") && this.GetComponent<SpriteRenderer>().color.a <= 0.5)
        {
            Physics2D.IgnoreCollision(collision.collider, playerCollider, true);
        }
    }
}
