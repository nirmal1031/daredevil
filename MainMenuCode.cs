using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class MainMenuCode : MonoBehaviour
{                                    // open class
    public void QuitGame()           // Quit button assigned to this function
    {                                // function open
        Application.Quit();          // line to close the application/game
    }                                // function closed
    public void LoadGame()           // Start button assigned to this function
    {                                // function open
        SceneManager.LoadScene("John The Explorer"); // line to load the next line in the build settings
    }                                 // function closed
}                                     // close class