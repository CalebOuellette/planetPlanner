using UnityEngine;
using System.Collections;


public class addForceByTime : MonoBehaviour {


	public float isFinishedLevel = 60; 
	public bool[] isBoost = new bool[isFinishedLevel];
	public float timer = 0;



	public void timerStart(){
		timer = 0;


	}

	public bool boostOn(){
		bool boostBool;
		float roundedA = Math.Round(timer, 0); 
		boostBool = isBoost [roundedA];


		return boostBool;
	}



	void FixedUpdate(){
		if (timer > isFinishedLevel) {
			timer += Time.deltaTime;
		}
	}



}
