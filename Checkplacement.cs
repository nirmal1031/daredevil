using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkplacement : MonoBehaviour
{
    BuildingManager buildingManager;
    void Start()
    {
        buildingManager = GameObject.Find("BuildingManager").GetComponent<BuildingManager>();
    }
    private void onTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Object"))
        {
            buildingManager.canPlace = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Object"))
        {
           buildingManager.canPlace = true;
        }
    }
}

