﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClicks : MonoBehaviour
{
    public Camera cam;
    public LabAgent Agent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GetWorldPosition();
        }
    }
    public void GetWorldPosition()
    {
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            Agent.AddMoveCommand(hit.point);
            
        }
    }

}