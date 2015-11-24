using UnityEngine;
using System.Collections;

public class ClickAndDrag : MonoBehaviour
{

    void OnMouseDown()
    {
       
            new Vector2(Input.mousePosition.x, Input.mousePosition.y);

    }


    void OnMouseDrag()
    {
        Vector2 curScreenPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);


        Vector2 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        transform.position = curPosition;

    }
}