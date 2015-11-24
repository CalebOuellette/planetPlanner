using UnityEngine;
using System.Collections;

public class baseObject : MonoBehaviour {

	//requires 2D rigid body

	private Vector2 startPosition;
	private Vector2 playerMovedStartPosition;


	// Use this for initialization
	void Start () {
		startPosition = GetComponent<Transform>().position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// Set postion to reset back to.
	public void setPlayerMovedStartPosition (){
		playerMovedStartPosition = GetComponent<Transform>().position;
	}

	//Reset object to level start postion
	public void resetToStart(){
		Transform rb = GetComponent<Transform>();
		rb.position = startPosition; 
	}

	//Reset object to player moved start postion
	public void resetToPMstartPosition (){
		Transform rb = GetComponent<Transform>();
		rb.position = playerMovedStartPosition; 
	}





}
