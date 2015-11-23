using UnityEngine;
using System.Collections;

public class baseObject : MonoBehaviour {

	//requires 2D rigid body?

	private Vector2 startPosition;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		startPosition = GetComponent<Transform>().position;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// Set postion to reset back to.
	public void startLevel(){
		startPosition = GetComponent<Transform>().position;
		rb = GetComponent<Rigidbody2D>();
		rb.isKinematic = false;
	}


	//Reset object to player moved start postion
	public void resetToStart (){
		Transform Tr = GetComponent<Transform>();
		rb.isKinematic = true;
		Tr.position = startPosition; 


	}





}
