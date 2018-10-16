using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class DevShop : MonoBehaviour {
    public Flowchart dev;
    public Flowchart collect;
    public Camera devCam;
    public GameObject hasPhotos0,hasPhotos1,hasPhotos2;
    public RawImage hasPhotos00, hasPhotos01, hasPhotos02;
    // Use this for initialization
    void Start () {
        devCam.enabled = false;
        collect.enabled = false;
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

        if(collect.GetBooleanVariable("givePhotos") == true)
        {
            AssetDatabase.Refresh();
            if(dev.GetFloatVariable("camPhotos") >= 0)
            {
                hasPhotos00.texture = Resources.Load<Texture2D>("Resources/Photo0)");

                hasPhotos0.active = true;
                


            }
            if(dev.GetFloatVariable("camPhotos") >= 1)
            {
                hasPhotos01.texture = Resources.Load<Texture2D>("Photo1)");

                hasPhotos1.active = true;
            }
            if(dev.GetFloatVariable("camPhotos") >= 2)
            {
                hasPhotos02.texture = Resources.Load<Texture2D>("Photo2)");
                hasPhotos2.active = true;

            }
            
            
        }

        if(dev.GetBooleanVariable("photoReady") == true)
        {

            dev.enabled = false;
            collect.enabled = true;

        }


      
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            collect.SendFungusMessage("talk");
            dev.SendFungusMessage("talk");
        }
    }
}
