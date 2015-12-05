using UnityEngine;
using System.Collections;

public class levelClock : MonoBehaviour {

    public float timeScaleFraction = 1;
    public int timeMax = 60;
    public float timer = 0;
    public bool started = false;
    private int trys = 0;
    float x= 0;



    public void timerStart()
    {
        timer = 0;
        started = true;
    }


    public void reset()
    {
        timer = 0;
        started = false;
        trys++;
        x = 0;
    }



    void Start()
    {
     
    }

    void FixedUpdate()
    {
        if (timer < timeMax && started)
        { //if timer is started and less than max time
            timer += Time.deltaTime * timeScaleFraction;
            if (timer > x)
            {
                Debug.Log(x);
                x++;
            }
        }
    }



}
