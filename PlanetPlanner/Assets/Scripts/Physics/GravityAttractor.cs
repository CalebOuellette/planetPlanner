using UnityEngine;
using System.Collections;

public class GravityAttractor : baseMoveableObject {

	public float gravity = -12;
	public float triggerDistance = 10;
    public float triggerDistanceBuffer = 3;

	private Transform planet;

   public void Awake ()
    {
        planet = GetComponent<Transform>();
		if (triggerDistance != -1) {
           
            GameObject line = Instantiate(Resources.Load("Line", typeof(GameObject)), planet.position, planet.rotation) as GameObject;

            Vector3 size = line.GetComponent<Renderer>().bounds.size;

            float scale = ((triggerDistance * 2) / size.y / planet.transform.localScale.x) ; //Divid by parent scale to get realworld scale.
       
            line.transform.parent = planet;

			line.transform.localScale = new Vector3(scale , scale, scale );
		}


    }


    public Vector2 Attract(Transform body) {

	    
		Vector2 gravityUp = (body.position - planet.position); //Get Vector between two points
        //Debug.Log(gravityUp.magnitude); 
		if (gravityUp.magnitude < triggerDistance || triggerDistance == -1) { //if the magnitude(distance) is less then trigger Distance, Apply gravity

            float scale = 1;

            if (gravityUp.magnitude > (triggerDistance - triggerDistanceBuffer)) //if buffer is set ship force will be multipled by a scaling number to gradually add force as the ship approatches the planet
            {
                float triggerbufferwork = triggerDistance - triggerDistanceBuffer;
                float gravitybuffer = gravityUp.magnitude - triggerbufferwork;
                //Debug.Log("gravitybuffer" + gravitybuffer);
                scale =  gravitybuffer/ triggerDistanceBuffer;
                //Debug.Log("scale" + scale);
            }
            

            gravityUp = (gravityUp.normalized * gravity * scale);
			return gravityUp;
		} else { //Else return a 0 vector. Equal to no force added.
			Vector2 x = new Vector2(0,0);
			return x;
		
		}

    }

  
}
