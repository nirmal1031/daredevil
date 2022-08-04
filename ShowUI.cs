using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    public GameObject uiObject;  //Creating a gameobject an invisible cube
    void Start()
    {
        uiObject.SetActive(false);   // setting the canvas inactive at start
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider player)  //Initializing the trigger function
    {
        if (player.gameObject.tag == "Player")  //condition to satisfy if the player collides with the gameobject
        {
            uiObject.SetActive(true);  // displaying the canvas which has the text
            StartCoroutine("WaitForSec"); // calling the counter function
        }
    }
    IEnumerator WaitForSec()       // initializing the counter wait function
    {
        yield return new WaitForSeconds(15);  // giving the time delay for wait
        Destroy(uiObject);                    // making the text disappear after the time delay
        Destroy(gameObject);                   // destroying the invisible cube object
    }
    
}
