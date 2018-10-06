using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class CameraDeveloper : MonoBehaviour {
    public Flowchart cameraDev;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {

            
            cameraDev.SendFungusMessage("interact");

        }
    }
}
