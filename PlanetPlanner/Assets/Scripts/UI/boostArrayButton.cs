using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class boostArrayButton : MonoBehaviour {

    public int ButtonID;
    private addForceByTime boostArray;
    private Rect buttonRect;
    private RectTransform buttonPosition;
	private bool buttonOnOff;
    

    public void toggleArray()
    {
        addForceByTime boostArray = FindObjectOfType(typeof(addForceByTime)) as addForceByTime;
        
			if (boostArray.isBoost[ButtonID] == true)
            {
				boostArray.isBoost[ButtonID] = false;


            }
            else
            {
				boostArray.isBoost[ButtonID] = true;
            }
        

    }

	
	public void toggleColor()
	{
		addForceByTime boostArray = FindObjectOfType(typeof(addForceByTime)) as addForceByTime;
		Button buttonButton = GetComponent<Button>();

		ColorBlock cb = buttonButton.colors;


		if (boostArray.isBoost[ButtonID] == true)
		{
			cb.normalColor  = Color.green;
			
			
		}
		else
		{
			cb.normalColor  = Color.white;
		}


		buttonButton.colors = cb;
		
	}

	public void highlight(){
		Button buttonButton = GetComponent<Button>();
		
		ColorBlock cb = buttonButton.colors;
		cb.normalColor  = Color.yellow;
		buttonButton.colors = cb;
	}

	public void unHighlight(){
		this.toggleColor();
		
	}



}
