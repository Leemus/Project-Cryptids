using System.Collections;
using System.Collections.Generic;
using UnityEngine.PostProcessing;
using UnityEngine;

public class Focus : MonoBehaviour {
    public PostProcessingProfile cam;
    float val;
    bool down = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var scroll = Input.GetAxis("Mouse ScrollWheel");
        var dof = cam.depthOfField.settings;
        dof.focusDistance = val;
        cam.depthOfField.settings = dof;
      
        if (down == true && scroll > 0)
        {
           
            val += 0.1f;

        }

        if(down == true & scroll < 0)
        {
            val -= 0.1f;

        }

        if (Input.GetKey(KeyCode.Z))
        {
            down = true;

        }
        else
        {
            down = false;
        }
    }

   
}
