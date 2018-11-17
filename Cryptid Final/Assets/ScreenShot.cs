using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenShot : MonoBehaviour
{
	public RawImage photos,photos1,photos2,photos3,photos4,photos5;
	public Texture2D image;
	
	IEnumerator ScreenCap()
	{


		yield return new WaitForEndOfFrame();
		var texture = ScreenCapture.CaptureScreenshotAsTexture();
		photos.texture = texture;

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(DevShop.goodbye);
		/*if (Input.GetMouseButton(0) && DevShop.goodbye == 0)
		{

			DevShop.goodbye += 1;
			photos.texture = ScreenCapture.CaptureScreenshotAsTexture();
		}
		
		if (Input.GetMouseButton(0) && DevShop.goodbye == 1)
		{

			DevShop.goodbye += 1;
			photos1.texture = ScreenCapture.CaptureScreenshotAsTexture();
		}
		if (Input.GetMouseButton(0) && DevShop.goodbye == 2)
		{

			DevShop.goodbye += 1;
			photos2.texture = ScreenCapture.CaptureScreenshotAsTexture();
		}
		*/
	}
	
	
}
	

