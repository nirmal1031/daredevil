using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour  // Class Collection is declared
{                                          // class is opened
    public AudioClip coinsound;            // an audio gameobject is declared
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);      // for making the coin rotate along the x-axis
    }
    private void OnTriggerEnter(Collider other)           // on trigger methode for detecting collision with the player
    {                                                     // open function
        if(other.name=="Player")                          // checking if the player collied with the coin object
        {                                                 // open if statement
            other.GetComponent<PlayerCollectCoins>().points++;   // calling the variable points from the PlayerCollectCoins class
            AudioSource.PlayClipAtPoint(coinsound, transform.position,0.5f); // creating an audio source at the point of the coin to output a sound when collected
            Destroy(gameObject);                                            // to delete the coin object once the player has collied with the coin
        }                                                         // close the if statement
    }                                                             // close the function
                               
}                                                                 // close class
