using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;
using UnityEngine.UI;

public class ScreenShot : MonoBehaviour
{
	public RawImage photos,photos1,photos2,photos3,photos4,photos5;
	public bool haveP, haveP1, haveP2, haveP3, haveP4, haveP5;
	//public Texture2D image;
	public bool camOn = false;
	public static float pin1, pin2, pin3, pin4, pin5, pin6;
	public int me;
	public Flowchart flow;
	
	IEnumerator ScreenCap()
	{


		yield return new WaitForEndOfFrame();
		var texture = ScreenCapture.CaptureScreenshotAsTexture();
		

	}
	
	// Update is called once per frame
	void Update () {
		
		flow.SetFloatVariable("points1", pin1);
		flow.SetFloatVariable("points2", pin2);
		flow.SetFloatVariable("points3", pin3);
		flow.SetFloatVariable("points4", pin4);
		flow.SetFloatVariable("points5", pin5);
		flow.SetFloatVariable("points6", pin6);
	//	Debug.Log(haveP1);
		if (Input.GetMouseButtonDown(0) && haveP == true && camOn == true)
		{
			photos.texture = ScreenCapture.CaptureScreenshotAsTexture();
			haveP = false;
			pin1 = CameraRay.total;
			me += 1;

		}

		if (Input.GetMouseButtonUp(0) && haveP == false && me == 1)
		{
			haveP1 = true;

		}
		
		if (Input.GetMouseButtonDown(0) && haveP1 == true && camOn == true)
		{
			haveP1 = false;
			me += 1;
			pin2 = CameraRay.total;             	//		haveP2 = true;
			photos1.texture = ScreenCapture.CaptureScreenshotAsTexture();
		}

		if (Input.GetMouseButtonUp(0) && haveP1 == false && me == 2)
		{
			haveP2 = true;
		}
		
		if (Input.GetMouseButtonUp(0) && haveP2 == true && camOn == true)
		{
			haveP2 = false;
			me += 1;
			pin3 = CameraRay.total;
			photos2.texture = ScreenCapture.CaptureScreenshotAsTexture();
		}

		if (Input.GetMouseButtonUp(0) && haveP2 == false && me == 3)
		{
			haveP3 = true;
			
		}

		if (Input.GetMouseButtonDown(0) && haveP3 == true && camOn == true)
		{

			haveP3 = false;
			me += 1;
			pin4 = CameraRay.total;
			photos3.texture = ScreenCapture.CaptureScreenshotAsTexture();
		}

		if (Input.GetMouseButtonUp(0) && haveP3 == false && me == 4)
		{
			haveP4 = true;


		}

		if (Input.GetMouseButtonDown(0) && haveP4 == true && camOn == true)
		{
			haveP4 = false;
			me += 1;
			photos4.texture = ScreenCapture.CaptureScreenshotAsTexture();
			pin5 = CameraRay.total;
		}

		if (Input.GetMouseButtonUp(0) && haveP4 == false && me == 5)
		{
			haveP5 = true;


		}

		if (Input.GetMouseButtonDown(0) && haveP5 == true && camOn == true)
		{
			haveP5 = false;
			me += 1;
			photos5.texture = ScreenCapture.CaptureScreenshotAsTexture();
			pin6 = CameraRay.total;

		}
	
		
		if (Input.GetKeyDown(KeyCode.E))
		{
			camOn = true ;



		}
		if (Input.GetKeyDown(KeyCode.Q))
		{
			camOn = false;



		}

		if (Input.GetKeyDown(KeyCode.I))
		{
			camOn = false;

		}
	}
	
	
}
	

