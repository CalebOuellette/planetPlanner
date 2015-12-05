using UnityEngine;
using System.Collections;

public class levelCompleteOnContact : MonoBehaviour
{

    public string nextLevel = "";

	void OnCollisionEnter2D(Collision2D col)
	{
		Debug.Log("collision");
		if (col.gameObject.name == "spaceship")
		{
           
                Application.LoadLevel(nextLevel);
            


        }
	}
}