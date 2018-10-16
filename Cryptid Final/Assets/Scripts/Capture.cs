using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor;
using Fungus;
using System;

public class Capture : MonoBehaviour {
    public static int Width = 1920;
    public static int Height = 1080;
    public Camera camera;
    public bool camOn;
    public RawImage[] canvas;
    public float[] range;
    public int size = 10;
    public Flowchart camDev;
    float add = 1;
    public static float file = -1;
    public AudioSource click;
    public bool hasFilm;
    
            
    private bool photocap = false;


  public static string ScreenShotName(int width, int height)
    {



      return string.Format("{0}/Resources/Photo{1}.png",
                       Application.dataPath, file += 1);

        


    }
   
    public void Update()
    {
        if (camDev.GetBooleanVariable("hasPhotos") == true)
        {

            hasFilm = false;

        }
        else
        {

            hasFilm = true;

        }
        photocap |= Input.GetMouseButtonDown(0);
        if (photocap && camOn == true && hasFilm == true)
        {
            RenderTexture rt = new RenderTexture(Width, Height, 24);
            camera.targetTexture = rt;
            Texture2D screenShot = new Texture2D(Width, Height, TextureFormat.RGB24, false);
            camera.Render();
            RenderTexture.active = rt;
            screenShot.ReadPixels(new Rect(0, 0, Width, Height), 0, 0);
            camera.targetTexture = null;
            RenderTexture.active = null;

            camDev.SetFloatVariable("camPhotos", add++);
            Destroy(rt);
            byte[] bytes = screenShot.EncodeToPNG();
            string filename = ScreenShotName(Width, Height);
            System.IO.File.WriteAllBytes(filename, bytes);
            Debug.Log(string.Format("Took screenshot to: {0}", filename));
            photocap = false;
           // click.Play();
        }

        

        if (Input.GetKeyDown(KeyCode.E))
        {
            camOn = true ;



        }
         if (Input.GetKeyDown(KeyCode.Q))
        {
            camOn = false;



        }
    }

    private void Start()
    {
        camOn = false;

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
