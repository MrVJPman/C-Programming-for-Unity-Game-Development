using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resizer : MonoBehaviour {

    //Timer support
    const float TotalResizeSeconds = 4;
    float elapsedResizeSeconds = 0;

    //Resizing control
    const float ScaleFactorPerSecond = 1;
    int scaleFactorSignMultiplier = 1;

    // Update is called once per frame
    void Update()
    {
        Vector3 newScale = transform.localScale;
        newScale.x += ScaleFactorPerSecond * scaleFactorSignMultiplier * Time.deltaTime;
        newScale.y += ScaleFactorPerSecond * scaleFactorSignMultiplier * Time.deltaTime;
        transform.localScale = newScale;


        elapsedResizeSeconds += Time.deltaTime;
        if (elapsedResizeSeconds >= TotalResizeSeconds)
        {
            elapsedResizeSeconds = 0;
            scaleFactorSignMultiplier *= -1;
        }
    }
}
