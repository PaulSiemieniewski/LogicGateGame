using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    // This script will be for any clickable or interactive objects. It is a simple script that can be used in UI and drag and drop features. It is contained to the Layer "ClickableObjects". 
    [SerializeField]
    private LayerMask ClickableObjects;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)
            )
        {
            RaycastHit RayHit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RayHit, Mathf.Infinity, ClickableObjects))
            {
                RayHit.collider.GetComponent<ClickOn>().ClickMe();

            }
        }
    }
}