using System.Collections;
using System.Collections.Generic;
using UnityEngine.PostProcessing;
using UnityEngine.UI;
using UnityEngine;

public class Focus : MonoBehaviour {
    public PostProcessingProfile cam;
    float val;
    public Camera photo;
    float zoomout = 13.7f;
    float zoomin = 56.7f;
    bool down = false;
    bool zoom = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var scroll = Input.GetAxis("Mouse ScrollWheel");
        var dof = cam.depthOfField.settings;
        dof.focusDistance = val;
        cam.depthOfField.settings = dof;
        
      
        if (down == true && scroll > 0)
        {
            
           
            val += 0.1f;

        }

        if(down == true && scroll < 0)
        {
            val -= 0.1f;

        }

        if(zoom == true && scroll > 0)
        {

            photo.focalLength += 0.5f;


        }

        if(zoom == true && scroll < 0)
        {
            photo.focalLength -= 0.5f;

        }

        if(zoom == true && Input.GetMouseButtonDown(2))
        {
            photo.focalLength = zoomout;

        }

        if (Input.GetKey(KeyCode.Z))
        {
            down = true;

        }
        else
        {
            down = false;
        }

        if (Input.GetKey(KeyCode.X))
        {
            zoom = true;

        }
        else
        {
            zoom = false;

        }


        if(photo.focalLength < zoomout)
        {
            photo.focalLength = zoomout;

        }

        if(photo.focalLength > zoomin)
        {
            photo.focalLength = zoomin;

        }
    }

   
}
