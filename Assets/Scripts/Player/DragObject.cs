using UnityEngine;

public class DragObject : MonoBehaviour
{
    Vector3 mousePosOffset;


    Vector3 mousePos(){
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }


    void OnMouseDown()
    {
        // Get the mouse position offset
        mousePosOffset = transform.position - mousePos();

    }

    void OnMouseDrag()
    {
        // Make the object follow the mouse position
        transform.position = mousePosOffset + mousePos();
    }
}
