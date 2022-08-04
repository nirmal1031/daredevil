using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour  // class declared
{                                          // open class
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()                           
    {                                       // open function
        transform.Rotate(0, 90 * Time.deltaTime, 0); // to rotate the object along the horizontal y-asix
    }                                               // close function
}                                            // close class
