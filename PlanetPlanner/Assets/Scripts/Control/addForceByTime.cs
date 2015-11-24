using UnityEngine;
using System.Collections;


public class addForceByTime : MonoBehaviour {


	public int timeMax = 60; 
	public bool[] isBoost = new bool[60];

	public float timer = 0;
	public bool started = false;


	public void timerStart(){
		timer = 0;
		started = true;
	}


	public void reset(){
		timer = 0;
		started = false;
	}



	public bool boostOn(){
		bool boostBool;
		int roundedA = (int) timer;
		//float roundedA = Math.Round(timer, 0); 
		boostBool = isBoost [roundedA];


		return boostBool;
	}



	void FixedUpdate(){
		if (timer < timeMax && started) {
			timer += Time.deltaTime;

			bool boost = this.boostOn();
			Debug.Log (boost);
		}
	}



}
