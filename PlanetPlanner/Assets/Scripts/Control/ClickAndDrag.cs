using UnityEngine;
using System.Collections;

public class ClickAndDrag : MonoBehaviour
{
    private levelClock levelClock;

    void Start()
    {
        levelClock = GameObject.Find("gameBase").GetComponent<levelClock>();
    }



    void OnMouseDown()
    {
       if(levelClock.started == false)
            new Vector2(Input.mousePosition.x, Input.mousePosition.y);

    }


    void OnMouseDrag()
    {
        if (levelClock.started == false)
        {
            Vector2 curScreenPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);


            Vector2 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
            transform.position = curPosition;
        }
    }
}