using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class DevShop : MonoBehaviour {
    public Flowchart dev;
    public Camera devCam;
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
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {

            dev.SendFungusMessage("talk");
        }
    }
}
