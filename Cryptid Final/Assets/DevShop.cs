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
    public bool havePhoto;
    public GameObject hasPhotos0,hasPhotos1,hasPhotos2;
    public RawImage hasPhotos00, hasPhotos01, hasPhotos02;
    // Use this for initialization
    void Start () {
        devCam.enabled = false;
        collect.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(havePhoto == true)
        {
            if (dev.GetFloatVariable("camPhotos") >= 0)
            {
                hasPhotos00.texture = Resources.Load<Texture2D>("Resources/Photo0)");
            }
            if (dev.GetFloatVariable("camPhotos") >= 1)
            {
                hasPhotos00.texture = Resources.Load<Texture2D>("Resources/Photo1)");
            }
            if (dev.GetFloatVariable("camPhotos") >= 2)
            {
                hasPhotos00.texture = Resources.Load<Texture2D>("Resources/Photo2)");
            }


        }




        if (dev.GetBooleanVariable("startConvo") == true)
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
                havePhoto = true;

                hasPhotos0.active = true;
                


            }
            if(dev.GetFloatVariable("camPhotos") >= 1)
            {
                havePhoto = true;

                hasPhotos1.active = true;
            }
            if(dev.GetFloatVariable("camPhotos") >= 2)
            {
                havePhoto = true;
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
