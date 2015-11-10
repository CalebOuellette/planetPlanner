using UnityEngine;
using System.Collections;

public class GravityAttractor : MonoBehaviour {

	public float gravity = -12;
	public float triggerDistance = 10;	
    
	private Transform planet;

   public void Awake ()
    {
        planet = GetComponent<Transform>();
		if (triggerDistance != -1) {

			GameObject line = Instantiate(Resources.Load("Line", typeof(GameObject)), planet.position, planet.rotation) as GameObject;
			float scale = (triggerDistance * 2 )/ 10; //fix
			line.transform.parent = planet;

			line.transform.localScale = new Vector3(scale , scale, scale );



		}


    }


    public Vector2 Attract(Transform body) {

	
		Vector2 gravityUp = (body.position - planet.position); //Get Vector between two points

		if (gravityUp.magnitude < triggerDistance || triggerDistance == -1) { //if the magnitude(distance) is less then trigger Distance, Apply gravity


			gravityUp = (gravityUp.normalized * gravity);
			return gravityUp;
		} else { //Else return a 0 vector. Equal to no force added.
			Vector2 x = new Vector2(0,0);
			return x;
		
		}

    }

  
}
