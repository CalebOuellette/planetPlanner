using UnityEngine;
using System.Collections;

public class baseMoveableObject : MonoBehaviour {

	//requires 2D rigid body?

	private Vector2 startPosition;
	private Rigidbody2D rb;


	private baseMoveableObject[] allMObjects;

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





	public static void resetAll(){
		baseMoveableObject[] allMObjects;
		allMObjects = FindObjectsOfType(typeof(baseMoveableObject)) as baseMoveableObject[];

		
		foreach (baseMoveableObject o in allMObjects) //For each planet/Attractor apply attractor force to ship.
		{
			o.resetToStart();
		}

	}

	
	
	public static void startLevelAll(){
		baseMoveableObject[] allMObjects;
		allMObjects = FindObjectsOfType(typeof(baseMoveableObject)) as baseMoveableObject[];
		
		
		foreach (baseMoveableObject o in allMObjects) //For each planet/Attractor apply attractor force to ship.
		{
			o.startLevel();
		}
		
	}





}
