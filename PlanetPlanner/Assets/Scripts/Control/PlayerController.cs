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

        levelClock = GameObject.Find("gameBaseScripts").GetComponent<levelClock>();
        spaceship = GameObject.Find("spaceship");
        rb = spaceship.GetComponent<Rigidbody2D>();
        body = spaceship.GetComponent<Transform>();

    }



    void Update()
    {
        if (UseArrowControls == true)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(Vector2.right * thrust);
                Debug.Log("right");

            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(Vector2.left * thrust);
                Debug.Log("left");
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.AddForce(Vector2.down * thrust);
                Debug.Log("down");
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(Vector2.up * thrust);
                Debug.Log("up");

            }

            if (Input.GetKey(KeyCode.B))
            {
                rb.AddForce(body.right * thrust);
                Debug.Log("Boost");

            }
        }



        if (Input.GetKeyDown(KeyCode.Space))
        {
            reset();
        }


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