using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class spawnBoostControl : MonoBehaviour {

    private RectTransform setButtonPlace;
    public Vector2 rectpos;
    public float spacing = 1;
    private int numOfButtons;



	// Use this for initialization
	void Start () {

        setButtonPlace = GetComponent<RectTransform>();
        rectpos = setButtonPlace.position;
        

        addForceByTime item = FindObjectOfType(typeof(addForceByTime)) as addForceByTime;
        numOfButtons = item.isBoost.Length;



        int x = 0;
        while ( x < numOfButtons) {
            GameObject buttonGameObject = Instantiate(Resources.Load("UI/boost", typeof(GameObject))) as GameObject;
            buttonGameObject.transform.SetParent(this.transform);
            boostArrayButton bArrayButton = buttonGameObject.GetComponent<boostArrayButton>();
            bArrayButton.ButtonID = x;

            //update POS
            RectTransform buttonlocation = buttonGameObject.GetComponent<RectTransform>();
            buttonlocation.position = rectpos;

            rectpos.x = rectpos.x + spacing;


            //increment
            x++;
        }
        

    }




}
