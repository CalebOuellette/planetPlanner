using UnityEngine;
using System.Collections;


public class GravityBody : MonoBehaviour {

    private GravityAttractor[] planet;
    private Transform body;

    public Vector2 startPosition;
    Vector2 addForce = new Vector2(0, 0);


    void Awake()
    {
       
        planet = FindObjectsOfType(typeof(GravityAttractor)) as GravityAttractor[]; //Find all "Attractors"
        body = GetComponent<Transform>(); //get Transform of ship

        //get start position for resetting moving objects
        startPosition = GetComponent<Rigidbody2D>().position;
        
    }

    void FixedUpdate()
    {

        addForce = Vector2.zero;
        foreach (GravityAttractor p in planet) //For each planet/Attractor apply attractor force to ship.
        {
            addForce = addForce + p.Attract(body);
        }

        body.GetComponent<Rigidbody2D>().AddForce(addForce);
        
    }
}


