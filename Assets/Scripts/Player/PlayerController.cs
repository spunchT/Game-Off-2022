using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed;


    private void Update() {
        // Get the input
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        Vector2 inputVector = new Vector2(horizontalInput, verticalInput); // The input vector where we combine the horizontal and vertical inputs

        // Move player
        rb.velocity = inputVector * speed * Time.deltaTime * 100; // Move the player by the inputVector * speed and Time.deltaTime (Multiplied by 100 so that we don't have to put a large number for the speed)

    }
}
