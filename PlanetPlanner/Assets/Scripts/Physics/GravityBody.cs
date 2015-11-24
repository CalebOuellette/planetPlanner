using UnityEngine;
using System.Collections;


public class GravityBody : baseMoveableObject {

    private GravityAttractor[] planet;
    private Transform body;
	

    public bool addRotation = true;
    Vector2 targetAddForce = new Vector2(0, 0);


    void Awake()
    {
       
        planet = FindObjectsOfType(typeof(GravityAttractor)) as GravityAttractor[]; //Find all "Attractors"
        body = GetComponent<Transform>(); //get Transform of ship
       
    }

    void FixedUpdate()
    {

		targetAddForce = Vector2.zero;
        
        foreach (GravityAttractor p in planet) //For each planet/Attractor apply attractor force to ship.
        {
			targetAddForce = targetAddForce + p.Attract(body);
        }


		//Add Boost funtion takes the existing vector and adds magnat to increase the velocity.

		body.GetComponent<Rigidbody2D>().AddForce(targetAddForce);



        if (addRotation == true) //Adds Rotation to the object if needed. Used for spaceship!
        {
            Vector2 localUp = body.right;
		
			Vector2 velocityShip = GetComponent<Rigidbody2D>().velocity.normalized; //Now rotates toward velocity. 


			Quaternion targetRotation = Quaternion.FromToRotation(localUp, velocityShip) * body.rotation;
			body.rotation = Quaternion.RotateTowards(body.rotation, targetRotation, 50f * Time.deltaTime );

        }


    }
}


