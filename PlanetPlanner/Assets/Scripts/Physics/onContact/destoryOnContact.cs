using UnityEngine;
using System.Collections;

public class destoryOnContact : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {        
        if (col.gameObject.name == "spaceship")
        {

			baseMoveableObject.resetAll();
        }
    }
}