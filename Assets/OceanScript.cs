//using System;
using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;

//using System.Diagnostics;
using UnityEngine;


public class OceanScript : MonoBehaviour
{
    string[] ocean = new string[10] { " Bass ", " Tuna ", " Crab ", "Eel", "Salmon", "Shark", "Mackeral", "Barracuda", "Octopus", "Scuba Steve"  }; // my list of available fish to catch
    int fishWeight;
    int fishLength;
    int fishValue;
    Fish myFish;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("What a day for fishing! Press A to start!");
        fishWeight = Random.Range(1, 150);
        fishLength = fishWeight + Random.Range(10, 90);
        
      //  Debug.Log("Players first Fish: " + ocean[Random.Range(0,ocean.Length)]); // Use to randomize fish catch
       // Debug.Log(" wow! What a Fish! " + " Fish Weighs " + fishWeight + "Kg" + " Fish Measures at " + fishLength + "Cm"); // after casting reel out
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            // Debug.Log("hello!");
            Debug.Log("Players first Fish: " + ocean[Random.Range(0, ocean.Length)]); // Use to randomize fish catch
          Debug.Log(" wow! What a Fish! " + " Fish Weighs " + fishWeight + "Kg" + " Fish Measures at " + fishLength + "Cm");
            Debug.Log(" Would you like to sell it or keep it? ");
            myFish = new Fish();

        }


        if (Input.GetKeyDown(KeyCode.F))

        {
            if (myFish != null)
            {
               Debug.Log(myFish.getFishCount());
            }
        }

    }
}
