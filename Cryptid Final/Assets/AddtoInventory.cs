﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AddtoInventory : MonoBehaviour {
   
    public RawImage[] canvas; 
    public Texture[] photos;
    public int index;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        AddtoCanvas();
        photos[0] = (Texture)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/screenshots/photo0.png",  typeof(Texture));
        photos[1] = (Texture)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/screenshots/photo0.png", typeof(Texture));
        photos[2] = (Texture)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/screenshots/photo0.png", typeof(Texture));
        photos[3] = (Texture)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/screenshots/photo0.png", typeof(Texture));
        photos[4] = (Texture)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/screenshots/photo0.png", typeof(Texture));
        photos[5] = (Texture)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/screenshots/photo0.png", typeof(Texture));
    }

    void AddtoCanvas()
    {
        
         canvas[0].texture = photos[0];
       // Debug.Log("me");
        

    }
}
