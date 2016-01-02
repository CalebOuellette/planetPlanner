using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{


    public int thrust = 10;
    public bool UseArrowControls = false;
    private Rigidbody2D rb;
    private Transform body;
    private levelClock levelClock;
    private GameObject spaceship;

    void Start()
    {

        levelClock = GameObject.Find("gameBase").GetComponent<levelClock>();
        spaceship = GameObject.Find("spaceship");
        rb = spaceship.GetComponent<Rigidbody2D>();
        body = spaceship.GetComponent<Transform>();

    }




    public void reset()
    {

        
        if (levelClock.started == false)
        {
            baseMoveableObject.startLevelAll();

        }
        else
        {
            baseMoveableObject.resetAll();

        }




    }

    public void spawnPlanet()
    {



    }

}