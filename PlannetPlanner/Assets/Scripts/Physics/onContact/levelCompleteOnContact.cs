using UnityEngine;
using System.Collections;

public class levelCompleteOnContact : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D col)
	{
		Debug.Log("collision");
		if (col.gameObject.name == "spaceship")
		{

			//Add victory event


			
		}
	}
}