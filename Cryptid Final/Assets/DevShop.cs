using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;
using UnityEditor;

public class DevShop : MonoBehaviour {
    public Flowchart dev;
    public Camera devCam;
    public GameObject[] hasPhotos;
	// Use this for initialization
	void Start () {
        devCam.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		if(dev.GetBooleanVariable("startConvo") == true)
        {
            devCam.enabled = true;

        }
        else
        {
        devCam.enabled = false;

        }

        if(dev.GetBooleanVariable("givePhotos") == true)
        {
            AssetDatabase.Refresh();
            if(dev.GetFloatVariable("camPhotos") >= 0)
            {
                hasPhotos[0].active = true;
            }
            if(dev.GetFloatVariable("camPhotos") >= 1)
            {

                hasPhotos[1].active = true;
            }
            if(dev.GetFloatVariable("camPhotos") >= 2)
            {
                hasPhotos[2].active = true;

            }
            

        }

      
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {

            dev.SendFungusMessage("talk");
        }
    }
}
