using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AddtoInventory : MonoBehaviour {
    public Canvas store;
    public Texture[] photos;
    public int index;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        photos[0] = (Texture)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/screenshots/photo0.png",  typeof(Texture));
    }
}
