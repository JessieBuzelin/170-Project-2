using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class Fish : ScriptableObject
{
    public int fishCount = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Fish added to collection!");
       
    }

    // Update is called once per frame
    void Update()
    {
        
        

    }
    public int getFishCount ()
    { return fishCount; }
}
