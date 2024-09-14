using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1.5f;
    /*public float rotationSpeed = 100.0f;*/
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d =  GetComponent<Rigidbody2D>();
    }

    

    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * speed, 0, 0);

        rb2d.velocity = movement;

        // Make it move 10 meters per second instead of 10 meters per frame...
        /*translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, translation);*/

        // Rotate around our y-axis
        /*transform.Rotate(0, rotation, 0);*/
    }

    void PlayerInput()
    {

        var horizontalInput = Input.GetAxisRaw("Horizontal");
        var verticalInput = Input.GetAxisRaw("Vertical") * Time.deltaTime;
    }
}
