using UnityEngine;
using System.Collections;

public class boostArrayButton : MonoBehaviour {

    public int ButtonID;
    private addForceByTime boostArray;
    private Rect buttonRect;
    private RectTransform buttonPosition;

    // Use this for initialization
    //void Start () {
    //    boostArray = FindObjectOfType(typeof(addForceByTime)) as addForceByTime;
    //    buttonPosition = GetComponent<RectTransform>();

    //    Vector2 x = new Vector2( buttonPosition.rect.width, buttonPosition.rect.height);
    //    buttonRect = new Rect(buttonPosition.position , x);

    //}

    //void OnGUI(){


    //    if (GUI.Button(buttonRect, ButtonID.ToString()))
    //    {
    //        if (boostArray.isBoost[ButtonID] == true)
    //        {
    //            GUI.color = Color.black;
    //            boostArray.isBoost[ButtonID] = false;
    //            Debug.Log("test" + boostArray.isBoost[ButtonID]);
    //        }
    //        else
    //        {
    //            GUI.color = Color.green;
    //            boostArray.isBoost[ButtonID] = true;
    //            Debug.Log("test" + boostArray.isBoost[ButtonID]);
    //        }
    //    }


    //}

    public void toggleArray(int item)
    {
        
        

        addForceByTime boostArray = FindObjectOfType(typeof(addForceByTime)) as addForceByTime;
        {
            if (boostArray.isBoost[item] == true)
            {
                boostArray.isBoost[item] = false;

            }
            else
            {
                boostArray.isBoost[item] = true;
            }

        }

    }



}
