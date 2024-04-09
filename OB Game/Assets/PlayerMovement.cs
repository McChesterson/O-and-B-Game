using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private Vector2 vel;
    private Vector2 forward;
    public float Thrust = 10;
    public float RotationSpeed = 2;
    Vector2 joystickL;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        joystickL.x = Input.GetAxis("Horizontal");
        joystickL.y = Input.GetAxis("Vertical");
        rb2d.rotation += -joystickL.x * RotationSpeed;
        if(Input.GetButton("Fire1"))
        {
            rb2d.velocity += forward * Thrust * Time.fixedDeltaTime;
        }
    }
    void Update()
    {
        forward = new Vector2(rb2d.transform.up.x, rb2d.transform.up.y);
        while (transform.position.x > 10)
        {
            transform.position = new Vector3(transform.position.x - 20, transform.position.y, transform.position.z);
        }
        while (transform.position.x < -10)
        {
            transform.position = new Vector3(transform.position.x + 20, transform.position.y, transform.position.z);
        }
        while (transform.position.y > 5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 10, transform.position.z);
        }
        while (transform.position.y < -5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 10, transform.position.z);
        }
    }
}

