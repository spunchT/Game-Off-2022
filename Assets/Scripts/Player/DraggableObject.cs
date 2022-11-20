using UnityEngine;

public class DraggableObject : MonoBehaviour
{
    public Camera mainCam;

    public float smooth;

    
    private void OnMouseDrag()
    {

        // Disable the gameObject's collider
        GetComponent<Collider2D>().enabled = false;


        // Get the mouse position
        Vector2 mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        
        // Move the object to the mouse position
        transform.position = mousePos;
    }
}