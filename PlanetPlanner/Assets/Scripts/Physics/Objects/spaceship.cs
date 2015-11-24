using UnityEngine;
using System.Collections;

public class spaceship : GravityBody {

	private Transform body;
	public int thrust = 10;






	// Use this for initialization
	void Start () {

		body = GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void addFowardForce(){

		this.rb.AddForce(body.right * thrust);
	}

	
	public void AddFowardForce(float InputThrust){
		this.rb.AddForce(body.right * InputThrust);
	}



}
