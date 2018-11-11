using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class CamSwitch : MonoBehaviour {

    public Camera mainCam;
    public Camera photoCam;
    public Camera invCam;
    public ThirdPersonUserControl player;
  //  public Animator playerani;

    // Use this for initialization
    void Start()
    {
        player = GetComponent<ThirdPersonUserControl>();
        mainCam.enabled = true;
        photoCam.enabled = false;
        invCam.enabled = false;
        player.enabled = true;
       // playerani.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {

        //Enable photo camera and disable main camera.
        if (Input.GetKeyDown(KeyCode.E))
        {
            mainCam.enabled = false;
            photoCam.enabled = true;
            invCam.enabled = false;
            player.enabled = false;
           // playerani.enabled = false;

        }

        //Enable main camera and disable photo camera.
        if (Input.GetKeyDown(KeyCode.Q))
        {
            mainCam.enabled = true;
            photoCam.enabled = false;
            invCam.enabled = false;
            player.enabled = true;
           // playerani.enabled = true;

        }

        //Enable Inventory camera and disable the other two.
        if (Input.GetKeyDown(KeyCode.I))
        {
            mainCam.enabled = false;
            photoCam.enabled = false;
            invCam.enabled = true;
            player.enabled = true;
           // playerani.enabled = true;
        }

   
    }
}
