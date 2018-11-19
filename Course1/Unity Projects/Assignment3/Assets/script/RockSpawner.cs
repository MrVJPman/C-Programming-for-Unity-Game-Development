using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour {


    //need this for spawning
    [SerializeField] GameObject prefabRock;

    //saved for efficiency
    [SerializeField] Sprite greenRock;
    [SerializeField] Sprite magnetaRock;
    [SerializeField] Sprite whiteRock;

    //spawn control in terms of time
    Timer spawnTimer;

    const int maxNumberOfRocks = 3;

    // Use this for initialization
    void Start() {

        //Creates and initiazes the timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = 1;
        spawnTimer.Run();
    }

    // Update is called once per frame
    void Update () {
        if (spawnTimer.Finished)
        {
            
            if (GameObject.FindGameObjectsWithTag("RockTag").Length < maxNumberOfRocks) {
                SpawnRock();
            }

            // change spawn timer duration and restart
            spawnTimer.Duration = 1;
            spawnTimer.Run();
        }
    }

    void SpawnRock()
    {
        // generate random location and create new teddy bear
        Vector3 location = new Vector3(Screen.width / 2,
            Screen.height / 2,
            -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
        GameObject rock = Instantiate(prefabRock) as GameObject;
        rock.transform.position = worldLocation;

        SpriteRenderer spriteRenderer = rock.GetComponent<SpriteRenderer>();
        int spriteNumber = Random.Range(0, 3);
        switch (spriteNumber) {
            case 0:
                spriteRenderer.sprite = greenRock;
                break;
            case 1:
                spriteRenderer.sprite = magnetaRock;
                break;
            case 2:
                spriteRenderer.sprite = whiteRock;
                break;
        }
    }
}
