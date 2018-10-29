using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRay : MonoBehaviour {
  //  public RaycastHit hitr;
  //  public GameObject test;
	public GameObject topLeftOr;

	public GameObject topRightOr;

	public GameObject botLeftOr;

	public GameObject botRightOr;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
		Debug.DrawRay(topLeftOr.transform.position, forward, Color.green);
		Debug.DrawRay(topRightOr.transform.position, forward, Color.blue);
		Debug.DrawRay(botLeftOr.transform.position, forward, Color.yellow);
		Debug.DrawRay(botRightOr.transform.position, forward, Color.magenta);


	}
}
