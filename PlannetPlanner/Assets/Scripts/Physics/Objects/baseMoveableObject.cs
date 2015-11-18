using UnityEngine;
using System.Collections;

public class baseMoveableObject : MonoBehaviour {

	//requires 2D rigid body

	private Vector2 startPosition;
	private Vector2 playerMovedStartPosition;


	// Use this for initialization
	void Start () {
		startPosition = GetComponent<Rigidbody2D>().position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// Set postion to reset back to.
	public void setPlayerMovedStartPosition (){
		playerMovedStartPosition = GetComponent<Rigidbody2D>().position;
	}

	//Reset object to level start postion
	public void resetToStart(){
		Rigidbody2D rb = GetComponent<Rigidbody2D>();
		rb.position = startPosition; 
	}

	//Reset object to player moved start postion
	public void resetToPMstartPosition (){
		Rigidbody2D rb = GetComponent<Rigidbody2D>();
		rb.position = playerMovedStartPosition; 
	}

}
