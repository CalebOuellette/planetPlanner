using UnityEngine;
using System.Collections;


public class GravityBody : MonoBehaviour {

    private GravityAttractor[] planet;
    private Transform body;

    public Vector2 startPosition;

    public bool addRotation = true;
    Vector2 targetAddForce = new Vector2(0, 0);
    Quaternion targetRotation = new Quaternion(0,0,0,0);


    void Awake()
    {
       
        planet = FindObjectsOfType(typeof(GravityAttractor)) as GravityAttractor[]; //Find all "Attractors"
        body = GetComponent<Transform>(); //get Transform of ship
       

        //get start position for resetting moving objects
        startPosition = GetComponent<Rigidbody2D>().position;
      //Set StartRotation
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
            Vector2 localUp = body.up;
			Quaternion targetRotation = Quaternion.FromToRotation(localUp, targetAddForce) * body.rotation;
			body.rotation = Quaternion.Slerp(body.rotation, targetRotation, 50f * Time.deltaTime );

        }


    }
}


