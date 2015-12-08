using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class spawnBoostControl : MonoBehaviour {

    private RectTransform setButtonPlace;
    public Vector2 rectpos;
    public float spacing = 1;
    private int numOfButtons;
	private Button buttonButton;


	// Use this for initialization
	void Start () {

        setButtonPlace = GetComponent<RectTransform>();
        rectpos = setButtonPlace.position;
        

        addForceByTime item = FindObjectOfType(typeof(addForceByTime)) as addForceByTime;
        numOfButtons = item.isBoost.Length;



        int x = 0;
        while ( x < numOfButtons) {
            GameObject buttonGameObject = Instantiate(Resources.Load("UI/boost", typeof(GameObject))) as GameObject;

			buttonGameObject.name = "boostArrayButton" + x;

            buttonGameObject.transform.SetParent(this.transform);
            boostArrayButton bArrayButton = buttonGameObject.GetComponent<boostArrayButton>();
            bArrayButton.ButtonID = x;



			//Add functions
			buttonButton = buttonGameObject.GetComponent<Button>();

			buttonButton.onClick.AddListener(() =>  bArrayButton.toggleArray() ); 

			buttonButton.onClick.AddListener(() =>  bArrayButton.toggleColor() ); 
			bArrayButton.toggleColor();

            //update POS
            RectTransform buttonlocation = buttonGameObject.GetComponent<RectTransform>();
            buttonlocation.position = rectpos;

            rectpos.x = rectpos.x + spacing;


            //increment
            x++;
        }
        

    }

	private boostArrayButton lastButton;
	private int lastid = -1;


	public void highlightButton(int id){

		if (id != lastid){
		GameObject highLightObject = GameObject.Find("boostArrayButton" + id);
		boostArrayButton y = highLightObject.GetComponent<boostArrayButton> ();
		y.highlight();
		
		if(lastButton != null){
			lastButton.unHighlight();
		}
		
		lastButton = y;
		lastid = id;
		}

	}







}
