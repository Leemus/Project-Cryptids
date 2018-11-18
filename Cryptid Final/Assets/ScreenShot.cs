using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenShot : MonoBehaviour
{
	public RawImage photos,photos1,photos2,photos3,photos4,photos5;
	public bool haveP, haveP1, haveP2, haveP3, haveP4, haveP5;
	//public Texture2D image;
	public bool camOn = false;
	public int me;
	
	IEnumerator ScreenCap()
	{


		yield return new WaitForEndOfFrame();
		var texture = ScreenCapture.CaptureScreenshotAsTexture();
		

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(haveP1);
		if (Input.GetMouseButtonDown(0) && haveP == true && camOn == true)
		{
			photos.texture = ScreenCapture.CaptureScreenshotAsTexture();
			haveP = false;
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
                          	//		haveP2 = true;
			photos1.texture = ScreenCapture.CaptureScreenshotAsTexture();
		}

		if (Input.GetMouseButtonUp(0) && haveP1 == false && me == 2)
		{
			haveP2 = true;
		}
		
		if (Input.GetMouseButtonUp(0) && haveP2 == true && camOn == true)
		{
			//haveP2 = false;

			photos2.texture = ScreenCapture.CaptureScreenshotAsTexture();
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
	

