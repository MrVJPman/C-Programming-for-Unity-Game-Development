using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Processes mouse button inputs
/// </summary>
public class MouseButtonProcessor : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;
    [SerializeField]
    GameObject prefabTeddyBear;

    // first frame input support
    bool spawnInputOnPreviousFrame = false;
	bool explodeInputOnPreviousFrame = false;

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update() {
        // spawn teddy bear as appropriate
        if (Input.GetAxis("SpawnTeddyBear") > 0) {
            if (!spawnInputOnPreviousFrame)
            {

                //Set input flag
                spawnInputOnPreviousFrame = true;

                //Get mouse position and then set the position where the teddy bear will spawn
                Vector3 clickPosition = Input.mousePosition;
                clickPosition.z = -Camera.main.transform.position.z;
                clickPosition = Camera.main.ScreenToWorldPoint(clickPosition);

                //Create teddy bear
                Instantiate<GameObject>(prefabTeddyBear, clickPosition, Quaternion.identity);
            }
        }
        else
        {
            spawnInputOnPreviousFrame = false;
        }

        // explode teddy bear as appropriate
        if (Input.GetAxis("ExplodeTeddyBear") > 0)
        {
            if (!explodeInputOnPreviousFrame)
            {
                explodeInputOnPreviousFrame = true;
                GameObject teddyBearToBeExploded = GameObject.FindWithTag("TeddyBear");
                if ((teddyBearToBeExploded  != null)) {
                    Instantiate<GameObject>(prefabExplosion, teddyBearToBeExploded.transform.position, Quaternion.identity);
                    Destroy(teddyBearToBeExploded);
                }
            }
        }
        else
        {
            explodeInputOnPreviousFrame = false;
        }

    }
}
