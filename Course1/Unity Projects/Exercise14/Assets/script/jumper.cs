using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumper : MonoBehaviour {
    //jump location support
    const float minX = -10;
    const float maxX = 10;
    const float minY = -5;
    const float maxY = 5;
    //timer support
    const float TotalJumpDelaySeconds = 1;
    float elapsedJumpDelaySeconds = 0;
    // Update is called once per frame
    void Update () {
        //timer support and check if its done
        elapsedJumpDelaySeconds += Time.deltaTime;
        if (elapsedJumpDelaySeconds >= TotalJumpDelaySeconds)
        {
            elapsedJumpDelaySeconds = 0;
            transform.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
        }
    }
}
