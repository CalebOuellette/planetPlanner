using UnityEngine;
using System.Collections;

public class spaceship : GravityBody {

	private Transform body;
	public int thrust = 10;
	private Rigidbody2D rb;





	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		body = GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void addFowardForce(){

		rb.AddForce(body.right * thrust);
	}

	
	public void AddFowardForce(float InputThrust){
		rb.AddForce(body.right * InputThrust);
	}



}
