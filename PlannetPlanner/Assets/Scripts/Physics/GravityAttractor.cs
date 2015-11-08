using UnityEngine;
using System.Collections;

public class GravityAttractor : MonoBehaviour {

	public float gravity = -12;
    private Transform planet;
    
   public void Awake ()
    {
        planet = GetComponent<Transform>();
    }


    public Vector2 Attract(Transform body) {
		Vector2 gravityUp = (body.position - planet.position).normalized;
        
        
        gravityUp = (gravityUp * gravity);

        return gravityUp;
    }
}
