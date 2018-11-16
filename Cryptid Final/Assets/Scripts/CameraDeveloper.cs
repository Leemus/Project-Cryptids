using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;
using UnityEditor;

public class CameraDeveloper : MonoBehaviour {
    public Flowchart cameraDev;
    public Texture[] photos;
    public BooleanVariable photosCollected; 


	void Start () {
		
	}
	

	void Update () {
     
        photos[0] = Resources.Load<Texture>("Photo0");
        photos[1] = Resources.Load<Texture>("Photo1");
        photos[2] = Resources.Load<Texture>("Photo2");
        photos[3] = Resources.Load<Texture>("Photo3");
        photos[4] = Resources.Load<Texture>("Photo4");
        photos[5] = Resources.Load<Texture>("Photo5");

        if (cameraDev.GetBooleanVariable("photosCollected") == true)
        {
          //  AssetDatabase.Refresh();

        }

       
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {

           
            cameraDev.SendFungusMessage("interact");


        }
    }
}
