using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRay : MonoBehaviour {
  //  public RaycastHit hitr;
  //  public GameObject test;
	//public Renderer c1, c2, c3, c4, c5, c6, c7, c8, c9;
	public GameObject topLeftOr;
    public GameObject topRightOr;
    public GameObject botLeftOr;
    public GameObject botRightOr;
	public GameObject midOr;
	public GameObject midRight;
	public GameObject midLeft;
	
	public float length = 10;
    float points;
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
		Debug.DrawRay(midOr.transform.position, forward, Color.black);
		Debug.DrawRay(midLeft.transform.position, forward, Color.white);
		Debug.DrawRay(midRight.transform.position, forward, Color.cyan);

		if (Physics.Raycast(topLeftOr.transform.position, topLeftOr.transform.forward, out hit))
		{
			hit.distance = length;
			if (hit.collider.tag == "ValObj")
			{

				Debug.Log("This is an NPC");
				//points += ValuedObject.valuePoint;
			//	Debug.Log("This is the point value" + points);

			}

		}
		else
		{
			points = 0;
		}

		
	}
	
	
	
	}

