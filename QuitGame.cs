using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour   // class declared
{                                       // open class
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()                         // function declared
    {                                     // open the function
        if(Input.GetKey(KeyCode.Escape))   // to check if the user has pressed the Escape Key
        {                                  // Open if condition
            Application.Quit();            // to quit the application
        }                                  // close the if condition
    }                                      // close the function
}                                          // close class
