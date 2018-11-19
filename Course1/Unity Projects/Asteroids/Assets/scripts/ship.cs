using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour {

    Rigidbody2D shipRigidbody2D;
    CircleCollider2D shipCircleCollider2D;
    float shipRadius;
    Vector2 thrustDirection;


    //Constants for ship movement/rotation
    const float ThrustForce = 5;
    const float RotateDegreesPerSecond = 90;

    // Use this for initialization
    void Start () {
        shipRigidbody2D = GetComponent<Rigidbody2D>();
        shipCircleCollider2D = GetComponent<CircleCollider2D>();
        shipRadius = shipCircleCollider2D.radius;
        //Determines the early direction the ship will thrust in. It will thrust in X only
        thrustDirection = new Vector2(1.0f, 0.0f);
    }

    //Process rotation when receiving input <- or ->
    void Update()
    {
        float rotationInput = Input.GetAxis("Rotate");
        if (rotationInput != 0)
        {
            float rotationAmount = RotateDegreesPerSecond * Time.deltaTime;
            if (rotationInput < 0)
            {
                rotationAmount *= -1;
            }
            transform.Rotate(Vector3.forward, rotationAmount);
            Vector3 newShipAngle = transform.eulerAngles;
            thrustDirection.x = Mathf.Cos(newShipAngle.z * Mathf.Deg2Rad);
            thrustDirection.y = Mathf.Sin(newShipAngle.z * Mathf.Deg2Rad);
        }
    }

    //Thrusts the ship in the thrustDirection, using this instead of update as dealing with RigidBody
    void FixedUpdate()
    {
        if (Input.GetAxis("Thrust") > 0)
        {
            shipRigidbody2D.AddForce(ThrustForce * thrustDirection, ForceMode2D.Force);
        }
  
    }

    //Wrap the ship after it has exited camera
    void OnBecameInvisible() {

        Vector3 shipPosition = transform.position;
        Vector2 newPosition = new Vector2();
        //If at right edge, respawn at left edge
        if (shipPosition.x + shipRadius > ScreenUtils.ScreenRight) {
            newPosition.x = ScreenUtils.ScreenLeft;
            newPosition.y = shipPosition.y;
        }
        //If at left edge, respawn at right edge
        if (shipPosition.x - shipRadius < ScreenUtils.ScreenLeft)
        {
            newPosition.x = ScreenUtils.ScreenRight;
            newPosition.y = shipPosition.y;
        }
        //If at top edge, respawn at bottom edge
        if (shipPosition.y + shipRadius > ScreenUtils.ScreenTop)
        {
            newPosition.x = shipPosition.x;
            newPosition.y = ScreenUtils.ScreenBottom;
        }
        //If at bottom edge, respawn at top edge
        if (shipPosition.y - shipRadius < ScreenUtils.ScreenBottom)
        {
            newPosition.x = shipPosition.x;
            newPosition.y = ScreenUtils.ScreenTop;
        }


   
        //If at Top Right corner, respawn at Bottom Left corner
        if (shipPosition.x + shipRadius > ScreenUtils.ScreenRight && shipPosition.y + shipRadius > ScreenUtils.ScreenTop)
        {
            newPosition.x = ScreenUtils.ScreenLeft;
            newPosition.y = ScreenUtils.ScreenBottom;
        }

        //If at Top Left corner, respawn at Right Left corner
        if ((shipPosition.x - shipRadius < ScreenUtils.ScreenLeft && shipPosition.y + shipRadius > ScreenUtils.ScreenTop))
        {
            newPosition.x = ScreenUtils.ScreenRight;
            newPosition.y = ScreenUtils.ScreenBottom;
        }

        //If at Bottom Right corner, respawn at Top Left corner
        if (shipPosition.x + shipRadius > ScreenUtils.ScreenRight && shipPosition.y - shipRadius < ScreenUtils.ScreenBottom)
        {
            newPosition.x = ScreenUtils.ScreenLeft;
            newPosition.y = ScreenUtils.ScreenTop;
        }

        //If at Bottom Left corner, respawn at Top Right corner
        if (shipPosition.x - shipRadius < ScreenUtils.ScreenLeft && shipPosition.y - shipRadius < ScreenUtils.ScreenBottom)
        {
            newPosition.x = ScreenUtils.ScreenRight;
            newPosition.y = ScreenUtils.ScreenTop;
        }

        transform.position = newPosition;
    }

}
