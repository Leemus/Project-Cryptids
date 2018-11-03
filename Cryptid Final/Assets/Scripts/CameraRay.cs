using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRay : MonoBehaviour {
  //  public RaycastHit hitr;
  //  public GameObject test;
	public Renderer c1, c2, c3, c4, c5, c6, c7, c8, c9;
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

		if (Physics.Raycast(topLeftOr.transform.position, topLeftOr.transform.forward, 10))
		{

		  c1.material.color = new Color(5,1,3);
			c2.material.color = new Color(5,1,3);
			c3.material.color = new Color(5,1,3);
			c4.material.color = new Color(5,1,3);
			c5.material.color = new Color(5,1,3);
			c6.material.color = new Color(5,1,3);
			c7.material.color = new Color(5,1,3);
			c8.material.color = new Color(5,1,3);
			c9.material.color = new Color(5,1,3);

		}
		else
		{
			c1.material.color = new Color(0,0,0);
			c2.material.color = new Color(0,0,0);
			c3.material.color = new Color(0,0,0);
			c4.material.color = new Color(0,0,0);
			c4.material.color = new Color(0,0,0);
			c5.material.color = new Color(0,0,0);
			c6.material.color = new Color(0,0,0);
			c7.material.color = new Color(0,0,0);
			c8.material.color = new Color(0,0,0);
			c9.material.color = new Color(0,0,0);
		}
	}
}
