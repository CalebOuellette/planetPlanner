using UnityEngine;
using System.Collections;


public class addForceByTime : MonoBehaviour {
	
	public bool[] isBoost = new bool[30];
	private spaceship s;
    private levelClock levelClock;
    private GameObject BaseGameObject;
    private SpriteRenderer SR;
	private spawnBoostControl item;

    private Animator boost;


    public bool boostOn(){
		bool boostBool;
		int roundedA = (int) (levelClock.timer);
		boostBool = isBoost [roundedA];


		return boostBool;
	}


	void Start(){
		s = GetComponent<spaceship>();
        levelClock = GameObject.Find("gameBase").GetComponent<levelClock>();
        SR = GetComponent<SpriteRenderer>();
        boost = GetComponent<Animator>();
        item = FindObjectOfType(typeof(spawnBoostControl)) as spawnBoostControl;
      
    }

	void FixedUpdate(){
		if (levelClock.timer < levelClock.timeMax && levelClock.started) { //if timer is started and less than max time
            levelClock.timer += Time.deltaTime;


			int roundedA = (int) (levelClock.timer);
			item.highlightButton(roundedA);


			if( this.boostOn() == true){ //if array at point in time is true
				s.addFowardForce();
                boost.enabled = true;
                //SR.sprite = s.ShipBoostsprite;
            }
            else
            {
              //  SR.sprite = s.Shipsprite;
                boost.enabled = false;
            }

		}
	}



}
