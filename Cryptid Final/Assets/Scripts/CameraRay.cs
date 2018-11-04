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
	public float points;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		RaycastHit hit;
		Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
		Debug.DrawRay(topLeftOr.transform.position, forward, Color.green);
		Debug.DrawRay(topRightOr.transform.position, forward, Color.blue);
		Debug.DrawRay(botLeftOr.transform.position, forward, Color.yellow);
		Debug.DrawRay(botRightOr.transform.position, forward, Color.magenta);

		if (Physics.Raycast(topLeftOr.transform.position, topLeftOr.transform.forward, out hit))
		{
			if (hit.collider.tag == "NPC")
			{

				//Debug.Log("This is an NPC");
				points += 20;
				Debug.Log("This is the point value" + points);

			}

		}
		else
		{
		
		}
	}
}
