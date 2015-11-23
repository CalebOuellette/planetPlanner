using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


    public int thrust = 10;
    private Rigidbody2D rb;
    private Transform body;
	private spaceship s;
	private addForceByTime afbt;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        body = GetComponent<Transform>();
		s = GetComponent<spaceship> ();
		afbt = GetComponent<addForceByTime> ();

    }



	void Update() {
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


        if (Input.GetKey(KeyCode.Space))
        {
			s.startLevel();
			afbt.timerStart();

        }

        if (Input.GetKey(KeyCode.R))
        {
			s.resetToStart();
			afbt.reset();
        }


}

}
