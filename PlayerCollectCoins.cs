using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerCollectCoins : MonoBehaviour  // class is declared
{                                                // class opened
    public int points = 0;                       // a variable is decalred to store the score count
    private GUIStyle guiStyle = new GUIStyle();  // a new private object is created
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()                                // function declared
    {                                                   // function opened
        guiStyle.fontSize = 42;                         // font size is declared
        GUI.Label(new Rect(20, 20, 200, 100), "Score: " + points, guiStyle); // to display the score on the screen
        if (points == 100)                                         // conditional statement to see if the player has scored 100 points
        {                                                          // open if statement
            SceneManager.UnloadSceneAsync("John The Explorer");    // to make the current scne inactive
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // to load the gamewinner scene
        }                                                          // close if statement
                                  
    }                                                              // close function
     
   
}                                                                  // close class
