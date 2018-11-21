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


/*
 * using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

Rigidbody2D rb2D;
Vector2 thrustDirection;
[SerializeField]
float ThrustForce = 1;

[SerializeField]
float rotateDegreesPerSecond = 5;

[SerializeField]
float directionz;

float dirx;
float diry;

float coliderRadius;

// Use this for initialization
void Start () {
rb2D = gameObject.GetComponent<Rigidbody2D>();
thrustDirection = new Vector2(1, 0);
coliderRadius = GetComponent<CircleCollider2D>().radius;

}

// Update is called once per frame
void Update () {
if (Input.GetAxis("Rotate") != 0)
{
float rotationInput = Input.GetAxis("Rotate"); 
// calculate rotation amount and apply rotation
float rotationAmount = rotateDegreesPerSecond * Time.deltaTime;
if (rotationInput < 0)
{
rotationAmount *= -1;
}
transform.Rotate(Vector3.forward, rotationAmount);
directionz = transform.eulerAngles.z;
dirx = Mathf.Cos(Mathf.Deg2Rad * directionz);
diry = Mathf.Sin(Mathf.Deg2Rad * directionz);
thrustDirection = new Vector2(dirx, diry);
}

}

private void FixedUpdate()
{
if (Input.GetAxis("Thrust") > 0)
{
rb2D.AddForce(thrustDirection * ThrustForce, ForceMode2D.Force);
}
}

private void OnBecameInvisible()
{
if(gameObject.transform.position.x > ScreenUtils.ScreenRight)
{
gameObject.transform.position = new Vector2(ScreenUtils.ScreenLeft, gameObject.transform.position.y);
}
if (gameObject.transform.position.x < ScreenUtils.ScreenLeft)
{
gameObject.transform.position = new Vector2(ScreenUtils.ScreenRight, gameObject.transform.position.y);
}
if (gameObject.transform.position.y > ScreenUtils.ScreenTop)
{
gameObject.transform.position = new Vector2(gameObject.transform.position.x, ScreenUtils.ScreenBottom);
}
if (gameObject.transform.position.y < ScreenUtils.ScreenBottom)
{
gameObject.transform.position = new Vector2(gameObject.transform.position.x, ScreenUtils.ScreenTop);
}

}
}
*/
