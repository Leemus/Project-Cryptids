using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

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
    float pointsr1, pointsr2, pointsr3, pointsr4, pointsr5,pointsr6, pointsr7;

	public static  float total;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		total = pointsr1 + pointsr2 + pointsr3 + pointsr4 + pointsr5 + pointsr6 + pointsr7;
		RaycastHit hit;
	   // Debug.Log("points" + total);
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

		
				pointsr1 = ValuedObject.valuePoint;
				
			}

		}
		else
		{
			pointsr1 = 0;
			total = 0;
		}
		
		if (Physics.Raycast(topRightOr.transform.position, topLeftOr.transform.forward, out hit))
		{
			hit.distance = length;
			if (hit.collider.tag == "ValObj")
			{

		
				pointsr2 = ValuedObject.valuePoint;
				//	Debug.Log("This is the point value" + points);

			}

		}
		else
		{
			pointsr2 = 0;
			total = 0;
		}
		
		if (Physics.Raycast(botLeftOr.transform.position, topLeftOr.transform.forward, out hit))
		{
			hit.distance = length;
			if (hit.collider.tag == "ValObj")
			{

			
				pointsr3 = ValuedObject.valuePoint;
				//	Debug.Log("This is the point value" + points);

			}

		}
		else
		{
			pointsr3 = 0;
			total = 0;
		}

		if (Physics.Raycast(botRightOr.transform.position, topLeftOr.transform.forward, out hit))
		{
			hit.distance = length;
			if (hit.collider.tag == "ValObj")
			{

			
				pointsr4 = ValuedObject.valuePoint;
				//	Debug.Log("This is the point value" + points);

			}

		}
		else
		{
			pointsr4 = 0;
			total = 0;
		}
		
		if (Physics.Raycast(midOr.transform.position, topLeftOr.transform.forward, out hit))
		{
			hit.distance = length;
			if (hit.collider.tag == "ValObj")
			{

				
				pointsr5 = ValuedObject.valuePoint;
				//	Debug.Log("This is the point value" + points);

			}

		}
		else
		{
			pointsr5 = 0;
			total = 0;
		}
		
		if (Physics.Raycast(midLeft.transform.position, topLeftOr.transform.forward, out hit))
		{
			hit.distance = length;
			if (hit.collider.tag == "ValObj")
			{

			
				pointsr6 = ValuedObject.valuePoint;
				//	Debug.Log("This is the point value" + points);

			}

		}
		else
		{
			pointsr6 = 0;
			total = 0;
		}
		
		if (Physics.Raycast(midRight.transform.position, topLeftOr.transform.forward, out hit))
		{
			hit.distance = length;
			if (hit.collider.tag == "ValObj")
			{

				
				pointsr7 = ValuedObject.valuePoint;
				//	Debug.Log("This is the point value" + points);

			}

		}
		else
		{
			pointsr7 = 0;
			total = 0;
		}
	}
	
	
	
	}

