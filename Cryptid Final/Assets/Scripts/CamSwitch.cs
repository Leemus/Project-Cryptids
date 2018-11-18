using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class CamSwitch : MonoBehaviour {

    public Camera mainCam;
    public Camera photoCam;
    public Camera invCam;
    public FirstPersonDrifter player;
    public MouseLook me;
    public Button but1,but2,but3,but4,but5,but6;

  //  public Animator playerani;

    // Use this for initialization
    void Start()
    {
        player = GetComponent<FirstPersonDrifter>();
        mainCam.enabled = true;
        photoCam.enabled = false;
        invCam.enabled = false;
        player.enabled = true;
        me.enabled = true;
        but1.enabled = true;
        but2.enabled = true;
        but3.enabled = true;
        but4.enabled = true;
        but5.enabled = true;
        but6.enabled = true;

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
            me.enabled = false;
            but1.enabled = true;
            but2.enabled = true;
            but3.enabled = true;
            but4.enabled = true;
            but5.enabled = true;
            but6.enabled = true;
            // playerani.enabled = false;

        }

        //Enable main camera and disable photo camera.
        if (Input.GetKeyDown(KeyCode.Q))
        {
            mainCam.enabled = true;
            photoCam.enabled = false;
            invCam.enabled = false;
            player.enabled = true;
            me.enabled = true;
            but1.enabled = true;
            but2.enabled = true;
            but3.enabled = true;
            but4.enabled = true;
            but5.enabled = true;
            but6.enabled = true;
            // playerani.enabled = true;

        }

        //Enable Inventory camera and disable the other two.
        if (Input.GetKeyDown(KeyCode.I))
        {
            mainCam.enabled = false;
            photoCam.enabled = false;
            invCam.enabled = true;
            player.enabled = false;
            me.enabled = false;
            but1.enabled = false;
            but2.enabled = false;
            but3.enabled = false;
            but4.enabled = false;
            but5.enabled = false;
            but6.enabled = false;
           // playerani.enabled = true;
       AssetDatabase.Refresh();
          


        }

   
    }
}
