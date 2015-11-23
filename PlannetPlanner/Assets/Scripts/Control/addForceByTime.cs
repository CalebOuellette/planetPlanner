using UnityEngine;
using System.Collections;


public class addForceByTime : MonoBehaviour {


	public int timeMax = 60; 
	public bool[] isBoost = new bool[60];
	private spaceship s;
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




	void Start(){
		s = GetComponent<spaceship>();
	
	}

	void FixedUpdate(){
		if (timer < timeMax && started) {
			timer += Time.deltaTime;


			if( this.boostOn() == true){
				Debug.Log (s);
				s.addFowardForce();

			}

		}
	}



}
