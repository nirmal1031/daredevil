using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideo : MonoBehaviour  // class declared
{                                       // open class
    public GameObject VideoPlayer;       // declare game object
    public int timeToStop;               // create an integer variable to hold time
   
    // Start is called before the first frame update
    void Start()                           // function decalred
    {                                      // open function
        VideoPlayer.SetActive(false);      // initialize the video player object to inactive state
    }                                      // close the function
    

    // Update is called once per frame
    void OnTriggerEnter (Collider player)  // function declared
    {                                      // open function
        if(player.gameObject.tag == "Player") // checking if the player collided with the information cube
        {                                     // open if statement
            VideoPlayer.SetActive(true);      //initialize the video player object to active state
            Destroy(VideoPlayer, timeToStop); // destroying the object after the video playback
            Destroy(gameObject);              // destroying the information cube game object
        }                                   // close if statement
    }                                       // close function
}                                           // close class
