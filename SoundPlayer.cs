using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour  // class declared
{                                         // open class
    public AudioClip clip;                // declare an audio variable to hold the user input file
    AudioSource audio;                    // declaring an audio source object
  
    // Start is called before the first frame update
    void Start()                             // function declared
    {                                        // function open
        audio = GetComponent<AudioSource>();  // getting the input audio file from the user
    }                                         // function closed
    void Update()                             // function declared
    {                                         // function closed
        transform.Rotate(0, 90 * Time.deltaTime, 0); // to rotate the information mark along the y-axis to create an animation effect
    }                                          // function closed

    private void OnTriggerEnter(Collider other) // function declared
    {                                           // open function
        if (other.name == "Player")             // to check if the player collided or not
        {                                       // open if statement 
            
            AudioSource.PlayClipAtPoint(clip, transform.position, 5.0f); // to play the user entered audio file at the point where the information mark is placed
            Destroy(gameObject);                // to destroy the information mark after collision with the player
            
        }                                       // close if statement
    }                                           // close function
}                                               // close class
