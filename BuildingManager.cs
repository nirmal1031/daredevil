using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingManager : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject pendingObject;
    [SerializeField] private Material[] materials;

    private Vector3 pos;

    private RaycastHit hit;
    [SerializeField] private LayerMask layermask;

    public float rotateAmount;
    public float gridsize;
    bool gridOn = true;
    public bool canPlace = true;
    [SerializeField] private Toggle gridToggle;

    // Update is called once per frame
    void Update()
    {
        if(pendingObject != null)
        {
            if (gridOn)
            {
                pendingObject.transform.position = new Vector3(
                    RoundtoNearestGrid(pos.x),
                    RoundtoNearestGrid(pos.y),
                    RoundtoNearestGrid(pos.z)
                    );
            }
            else { pendingObject.transform.position = pos; }

            if (Input.GetMouseButtonDown(0) && canPlace)
            {
                PlaceObject();
            }
            if(Input.GetKeyDown(KeyCode.R))
            {
                RotateObject();
            }
            UpdateMaterials();
        }
    }

    public void PlaceObject()
    {
        pendingObject.GetComponent<MeshRenderer>().material = materials[2];
        pendingObject = null;
    }

    public void RotateObject()
    {
        pendingObject.transform.Rotate(Vector3.up, rotateAmount);
    }

    private void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, 1000, layermask))
        {
            pos = hit.point;
        }
    }
    public void UpdateMaterials()
    {
        if(canPlace)
        {
            pendingObject.GetComponent<MeshRenderer>().material = materials[0];
        }
        if(!canPlace)
        {
            pendingObject.GetComponent<MeshRenderer>().material = materials[1];
        }
    }

    public void SelectObject(int index)
    {
        pendingObject = Instantiate(objects[index], pos, transform.rotation);
    }

    public void ToggleGrid()
    {
        if(gridToggle.isOn)
        {
            gridOn = true;
        }
        else { gridOn = false; }
    }

    float RoundtoNearestGrid(float pos)
    {
        float xDiff = pos % gridsize;
        pos -= xDiff;
        if(xDiff > (gridsize / 2))
        {
            pos += gridsize;
        }
        return pos;
    }
    
}
