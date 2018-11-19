using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertTemperature : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int originalOne = 0;
        print(originalOne + ", " + ((originalOne - 32) / 9 * 5) + ", " + ((((originalOne - 32) / 9 * 5) * 9 / 5) + 32));
        int originalTwo = 32;
        print(originalTwo + ", " + ((originalTwo - 32) / 9 * 5) + ", " + ((((originalTwo - 32) / 9 * 5) * 9 / 5) + 32));
        int originalThree = 212;
        print(originalThree + ", " + ((originalThree - 32) / 9 * 5) + ", " + ((((originalThree - 32) / 9 * 5) * 9 / 5) + 32));


        const float temperatureInFahrenheit = 0;
        float temperatureInCelcius = (temperatureInFahrenheit - 32) / 9 * 5;
        float temperatureBackInFahrenheit = temperatureInCelcius * 9 / 5 + 32;
        print(temperatureInFahrenheit + ", " + temperatureInCelcius + ", " + temperatureBackInFahrenheit);

        const double temperatureInFahrenheit2 = 0;
        double temperatureInCelcius2 = (temperatureInFahrenheit2 - 32) / 9 * 5;
        double temperatureBackInFahrenheit2 = temperatureInCelcius2 * 9 / 5 + 32;
        print(temperatureInFahrenheit2 + ", " + temperatureInCelcius2 + ", " + temperatureBackInFahrenheit2);

    }
}
