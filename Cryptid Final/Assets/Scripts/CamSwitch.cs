using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour {

    public Camera mainCam;
    public Camera photoCam;
   


    // Use this for initialization
    void Start()
    {
        mainCam.enabled = true;
        photoCam.enabled = false;
    
   
   
    }

    // Update is called once per frame
    void Update()
    {

        //Enable photo camera and disable main camera.
        if (Input.GetKeyDown(KeyCode.E))
        {
            mainCam.enabled = false;
            photoCam.enabled = true;
          


        }

        //Enable main camera and disable photo camera.
        if (Input.GetKeyDown(KeyCode.Q))
        {
            mainCam.enabled = true;
            photoCam.enabled = false;
            


        }

   
    }
}
