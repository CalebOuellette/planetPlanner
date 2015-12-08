using UnityEngine;
using System.Collections;

public class maxSpeed : MonoBehaviour {

	public int speedMax = 10;
	private Rigidbody2D body;


	private 

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D>(); 

	}
	

	void FixedUpdate () {
		Debug.Log(body.velocity.magnitude);
		if (body.velocity.magnitude > speedMax) {

			Vector2 correctedSpeed = body.velocity.normalized;
			correctedSpeed = correctedSpeed * speedMax;
			body.velocity = correctedSpeed;

		}



	}
}
