using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Fungus;
using System;

public class Capture : MonoBehaviour {
    public static int Width = 1920;
    public static int Height = 1080;
    public Camera camera;
    public RawImage[] canvas;
    public float[] range;
    public int size = 10;
    public Flowchart camDev;
    public static float file = -1;

    private bool photocap = false;


  public static string ScreenShotName(int width, int height)
    {



      return string.Format("{0}/Resources/Photo{1}.png",
                       Application.dataPath, file += 1);




    }

    public void Update()
    {
        photocap |= Input.GetMouseButtonDown(0);
        if (photocap)
        {
            RenderTexture rt = new RenderTexture(Width, Height, 24);
            camera.targetTexture = rt;
            Texture2D screenShot = new Texture2D(Width, Height, TextureFormat.RGB24, false);
            camera.Render();
            RenderTexture.active = rt;
            screenShot.ReadPixels(new Rect(0, 0, Width, Height), 0, 0);
            camera.targetTexture = null;
            RenderTexture.active = null;
            Destroy(rt);
            byte[] bytes = screenShot.EncodeToPNG();
            string filename = ScreenShotName(Width, Height);
            System.IO.File.WriteAllBytes(filename, bytes);
            Debug.Log(string.Format("Took screenshot to: {0}", filename));
            photocap = false;
            
        }

        if (Input.GetMouseButton(0))
        {

          camDev.SetFloatVariable("camPhotos", +1);
        }
    }

    private void Start()
    {
        
        range[0] = 0f;
        range[1] = 1f;
        range[2] = 2f;
        range[3] = 3f;
        range[4] = 4f;
        range[5] = 5f;

    }

    public void TakeHiResShot()
    {
        photocap = true;
    }

    
}
