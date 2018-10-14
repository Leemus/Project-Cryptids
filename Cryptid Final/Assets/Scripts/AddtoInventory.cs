using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AddtoInventory : MonoBehaviour {
   
    public RawImage[] canvas; 
    public Texture[] photos;
   // public int index;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        AddtoCanvas();
        photos[0] = Resources.Load<Texture>("Photo0");
      //  photos[1] = (Texture)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Resources/screenshots/photo1.png", typeof(Texture));
      //  photos[2] = (Texture)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Resources/screenshots/photo2.png", typeof(Texture));
      //  photos[3] = (Texture)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Resources/screenshots/photo3.png", typeof(Texture));
      //  photos[4] = (Texture)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Resources/screenshots/photo4.png", typeof(Texture));
      //  photos[5] = (Texture)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Resources/screenshots/photo5.png", typeof(Texture));
       
    }

    void AddtoCanvas()
    {
        
       canvas[0].texture = photos[0];
      //  canvas[1].texture = photos[1];
       // canvas[2].texture = photos[2];
      //  canvas[3].texture = photos[3];
      //  canvas[4].texture = photos[4];
      //  canvas[5].texture = photos[5];
        

        


    }
}
