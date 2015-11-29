using UnityEngine;
using System.Collections;

public class baseMoveableObject : MonoBehaviour {

	//requires 2D rigid body?

	public Vector2 startPosition;
	public Quaternion startRotation;
	public Rigidbody2D rb;


	private baseMoveableObject[] allMObjects;

	// Use this for initialization
	void Start () {
		startPosition = GetComponent<Transform>().position;
		startRotation = GetComponent<Transform>().rotation;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// Set postion to reset back to.
	public void startLevel(){
		startPosition = GetComponent<Transform>().position;
		startRotation = GetComponent<Transform>().rotation;
		rb = GetComponent<Rigidbody2D>();
		rb.isKinematic = false;
	}


	//Reset object to player moved start postion
	public void resetToStart (){
		Transform Tr = GetComponent<Transform>();

		rb.isKinematic = true;
		Tr.position = startPosition;
		Tr.rotation = startRotation;


	}





	public static void resetAll(){
		baseMoveableObject[] allMObjects;
		allMObjects = FindObjectsOfType(typeof(baseMoveableObject)) as baseMoveableObject[];

        GameObject.Find("gameBaseScripts").GetComponent<levelClock>().reset();  //Reset Global Timer
        
        foreach (baseMoveableObject o in allMObjects) //For each planet/Attractor apply attractor force to ship.
		{
			o.resetToStart();
		}

	}

	
	
	public static void startLevelAll(){
		baseMoveableObject[] allMObjects;
		allMObjects = FindObjectsOfType(typeof(baseMoveableObject)) as baseMoveableObject[];

        GameObject.Find("gameBaseScripts").GetComponent<levelClock>().timerStart(); //Start Global Timer

        foreach (baseMoveableObject o in allMObjects) //For each planet/Attractor apply attractor force to ship.
		{
			o.startLevel();
		}
		
	}





}
