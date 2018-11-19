using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        //
        if (Input.GetMouseButtonDown(0)) {
            //Gets mouse position and render it as a 2D world position
            Vector3 mouseLeftPressedPosition = Input.mousePosition;
            mouseLeftPressedPosition.z = -Camera.main.transform.position.z;
            mouseLeftPressedPosition = Camera.main.ScreenToWorldPoint(mouseLeftPressedPosition);

            //Relocates attached game object to where the mouse was clicked
            gameObject.transform.position = mouseLeftPressedPosition;
            //Reminder : gameObject really isn't needed, and I can jsut do transform.position next time


            //print(gameObject.transform.position.x);
            //print(gameObject.transform.position.y);

        }
    }
}
