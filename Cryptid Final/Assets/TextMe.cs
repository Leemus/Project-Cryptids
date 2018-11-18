using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using Fungus;
using UnityEngine;
using UnityEngine.UI;

public class TextMe : MonoBehaviour
{
	public Text me;

	public Flowchart flowy;
	// Use this for initialization
	void Start ()
	{
		me.text = "Points";
	}
	
	// Update is called once per frame
	void Update () {
		if (flowy.GetBooleanVariable("p1") == true)
		{
			Debug.Log("hello");
			me.text = "Points:" + flowy.GetFloatVariable("points1");
			//me.enabled = true;

		}
		else
		{
			
		}
		if (flowy.GetBooleanVariable("p2") == true)
		{
			me.text = "" + ScreenShot.pin2;

		}
		else
		{
			//me.text = "";
		}
		if (flowy.GetBooleanVariable("p3") == true)
		{
			me.text = "" + ScreenShot.pin3;

		}
		else
		{
			//me.text = "";
		}
		if (flowy.GetBooleanVariable("p4") == true)
		{
			me.text = "" + ScreenShot.pin4;

		}
		else
		{
			//me.text = "";
		}
		if (flowy.GetBooleanVariable("p5") == true)
		{
			me.text = "" + ScreenShot.pin5;

		}
		else
		{
			//me.text = "";
		}
		if (flowy.GetBooleanVariable("p6") == true)
		{
			me.text = "" + ScreenShot.pin6;

		}
		else
		{
			//me.text = "";
		}
	}
}
