using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValuedObject : MonoBehaviour
{
	public float pointValue;

	public static float valuePoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		valuePoint = pointValue;
	}
}
