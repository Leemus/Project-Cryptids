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
    public Texture photo0, photo1, photo2;
    public static float goodbye = 0;
    // Use this for initialization
    void Start () {
        devCam.enabled = false;
        collect.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
       

        

    /*    if (dev.GetBooleanVariable("startConvo") == true)
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
          //  dev.GetFloatVariable("camPhotos") >= 0
            if(goodbye >= 0)
            {
                Debug.Log("lol");

                hasPhotos0.active = true;
                photo0 = (Texture)AssetDatabase.LoadAssetAtPath("Assets/Resources/Photo0.png", typeof(Texture));
                hasPhotos00.texture = photo0;


            }
            if(goodbye >= 1)
            {
                havePhoto = true;

                hasPhotos1.active = true;
                photo1 = (Texture)AssetDatabase.LoadAssetAtPath("Assets/Resources/Photo1.png", typeof(Texture));
                ;
                hasPhotos01.texture = photo1;
            }
            if(goodbye >= 2)
            {
                havePhoto = true;
                hasPhotos2.active = true;
                photo2 = (Texture)AssetDatabase.LoadAssetAtPath("Assets/Resources/Photo2.png", typeof(Texture));
                hasPhotos02.texture = photo2;
            }
            
            
        }
	    */
		if(goodbye >= 0)
	    {
	      //  Debug.Log("lol");

	        hasPhotos0.active = true;
	        photo0 = (Texture)AssetDatabase.LoadAssetAtPath("Assets/Resources/Photo0.png", typeof(Texture));
	        hasPhotos00.texture = photo0;


	    }
	    if(goodbye >= 1)
	    {
	        havePhoto = true;

	        hasPhotos1.active = true;
	        photo1 = (Texture)AssetDatabase.LoadAssetAtPath("Assets/Resources/Photo1.png", typeof(Texture));
	        ;
	        hasPhotos01.texture = photo1;
		    pointValue.points = CameraRay.total;
	    }
	    if(goodbye >= 2)
	    {
	    
	        hasPhotos2.active = true;
	        photo2 = (Texture)AssetDatabase.LoadAssetAtPath("Assets/Resources/Photo2.png", typeof(Texture));
	        hasPhotos02.texture = photo2;
	    }

     /*   if(dev.GetBooleanVariable("photoReady") == true)
        {

            dev.enabled = false;
            collect.enabled = true;

        }
    */

      
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
