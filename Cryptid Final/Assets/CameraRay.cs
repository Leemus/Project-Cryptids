using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRay : MonoBehaviour {
    public RaycastHit hitr;
    public GameObject test;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
        Vector3 forwardDir = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forwardDir, Color.red);



        if (hitr.collider.gameObject.name == "Test"){


            Destroy(test);
        



        }
    }
}
