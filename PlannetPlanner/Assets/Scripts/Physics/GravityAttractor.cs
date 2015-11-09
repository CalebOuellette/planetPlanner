using UnityEngine;
using System.Collections;

public class GravityAttractor : MonoBehaviour {

	public float gravity = -12;
	public float triggerDistance = 10;	
    
	private Transform planet;

   public void Awake ()
    {
        planet = GetComponent<Transform>();
    }


    public Vector2 Attract(Transform body) {

	
		Vector2 gravityUp = (body.position - planet.position); //Get Vector between two points

		if (gravityUp.magnitude < triggerDistance) { //if the magnitude(distance) is less then trigger Distance, Apply gravity


			gravityUp = (gravityUp.normalized * gravity);
			return gravityUp;
		} else { //Else return a 0 vector. Equal to no force added.
			Vector2 x = new Vector2(0,0);
			return x;
		
		}

    }

  
}
