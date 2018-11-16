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
    public GameObject hasPhotos0,hasPhotos1,hasPhotos2, hasPhotos3, hasPhotos4,hasPhotos5,hasPhotos6,hasPhotos7,hasPhotos8,hasPhotos9,hasPhotos10,hasPhotos11,hasPhotos12;
    public RawImage hasPhotos00, hasPhotos01, hasPhotos02,hasPhotos03, hasPhotos04,hasPhotos05,hasPhotos06,hasPhotos07,hasPhotos08,hasPhotos09,hasPhotos010,hasPhotos011,hasPhotos012;
    public Texture photo0, photo1, photo2, photo3, photo4, photo5, photo6, photo7, photo8, photo9, photo10, photo11, photo12;
    public static float goodbye = 0;
	public static float points;
	
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
		    photo0 = Resources.Load<Texture2D>("Photos/Photo0");
	        hasPhotos00.texture = photo0;
		   // this.hasPhotos00.points = CameraRay.total;


	    }
	    if(goodbye >= 1)
	    {
	        havePhoto = true;

	        hasPhotos1.active = true;
	      //  photo1 = (Texture)AssetDatabase.LoadAssetAtPath("Assets/Resources/Photo1.png", typeof(Texture));
	        ;photo1 = Resources.Load<Texture2D>("Photos/Photo1");
	        hasPhotos01.texture = photo1;
		  
	    }
	    if(goodbye >= 2)
	    {
	    
	        hasPhotos2.active = true;
	      //  photo2 = (Texture)AssetDatabase.LoadAssetAtPath("Assets/Resources/Photo2.png", typeof(Texture));
	        hasPhotos02.texture = photo2;
		    photo2 = Resources.Load<Texture2D>("Photos/Photo2");
	    }
        
		if(goodbye >= 3)
		{
	    
			hasPhotos2.active = true;
			//  photo2 = (Texture)AssetDatabase.LoadAssetAtPath("Assets/Resources/Photo2.png", typeof(Texture));
			hasPhotos02.texture = photo2;
			photo2 = Resources.Load<Texture2D>("Photo2");
		}
		if(goodbye >= 4)
		{
	    
			hasPhotos2.active = true;
			//  photo2 = (Texture)AssetDatabase.LoadAssetAtPath("Assets/Resources/Photo2.png", typeof(Texture));
			hasPhotos02.texture = photo2;
			photo2 = Resources.Load<Texture2D>("Photo2");
		}
		if(goodbye >= 5)
		{
	    
			hasPhotos2.active = true;
			//  photo2 = (Texture)AssetDatabase.LoadAssetAtPath("Assets/Resources/Photo2.png", typeof(Texture));
			hasPhotos02.texture = photo2;
			photo2 = Resources.Load<Texture2D>("Photo2");
		}
		if(goodbye >= 6)
		{
	    
			hasPhotos2.active = true;
			//  photo2 = (Texture)AssetDatabase.LoadAssetAtPath("Assets/Resources/Photo2.png", typeof(Texture));
			hasPhotos02.texture = photo2;
			photo2 = Resources.Load<Texture2D>("Photo2");
		}
		if(goodbye >= 2)
		{
	    
			hasPhotos2.active = true;
			//  photo2 = (Texture)AssetDatabase.LoadAssetAtPath("Assets/Resources/Photo2.png", typeof(Texture));
			hasPhotos02.texture = photo2;
			photo2 = Resources.Load<Texture2D>("Photo2");
		}
		if(goodbye >= 2)
		{
	    
			hasPhotos2.active = true;
			//  photo2 = (Texture)AssetDatabase.LoadAssetAtPath("Assets/Resources/Photo2.png", typeof(Texture));
			hasPhotos02.texture = photo2;
			photo2 = Resources.Load<Texture2D>("Photo2");
		}
		if(goodbye >= 2)
		{
	    
			hasPhotos2.active = true;
			//  photo2 = (Texture)AssetDatabase.LoadAssetAtPath("Assets/Resources/Photo2.png", typeof(Texture));
			hasPhotos02.texture = photo2;
			photo2 = Resources.Load<Texture2D>("Photo2");
		}
		if(goodbye >= 2)
		{
	    
			hasPhotos2.active = true;
			//  photo2 = (Texture)AssetDatabase.LoadAssetAtPath("Assets/Resources/Photo2.png", typeof(Texture));
			hasPhotos02.texture = photo2;
			photo2 = Resources.Load<Texture2D>("Photo2");
		}
		if(goodbye >= 2)
		{
	    
			hasPhotos2.active = true;
			//  photo2 = (Texture)AssetDatabase.LoadAssetAtPath("Assets/Resources/Photo2.png", typeof(Texture));
			hasPhotos02.texture = photo2;
			photo2 = Resources.Load<Texture2D>("Photo2");
			
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
