using UnityEngine;
using System.Collections;


public class addForceByTime : MonoBehaviour {
	
	public bool[] isBoost = new bool[60];
	private spaceship s;
    private levelClock levelClock;
    private GameObject BaseGameObject;
    private SpriteRenderer SR;




    public bool boostOn(){
		bool boostBool;
		int roundedA = (int) (levelClock.timer * levelClock.timeScaleFraction);
		boostBool = isBoost [roundedA];


		return boostBool;
	}


	void Start(){
		s = GetComponent<spaceship>();
        levelClock = GameObject.Find("gameBaseScripts").GetComponent<levelClock>();
        SR = GetComponent<SpriteRenderer>();
      
      
    }

	void FixedUpdate(){
		if (levelClock.timer < levelClock.timeMax && levelClock.started) { //if timer is started and less than max time
            levelClock.timer += Time.deltaTime;


			if( this.boostOn() == true){ //if array at point in time is true
				s.addFowardForce();
                SR.sprite = s.ShipBoostsprite;
            }
            else
            {
                SR.sprite = s.Shipsprite;
            }

		}
	}



}
