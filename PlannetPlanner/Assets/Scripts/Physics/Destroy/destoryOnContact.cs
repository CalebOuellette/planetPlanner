using UnityEngine;
using System.Collections;

public class destoryOnContact : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("collision");
        if (col.gameObject.name == "spaceship")
        {
            Rigidbody2D rb = col.gameObject.GetComponent<Rigidbody2D>();
          

            rb.isKinematic = true; //stop applying gravity
            rb.position = col.gameObject.GetComponent<GravityBody>().startPosition;
           
        }
    }
}