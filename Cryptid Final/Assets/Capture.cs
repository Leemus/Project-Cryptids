using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Capture : MonoBehaviour {
    public int Width = 2550;
    public int Height = 3300;
    public Camera camera;
    private bool photocap = false;
    

    public static string ScreenShotName(int width, int height)
    {
        return string.Format("{0}/screenshots/CameraPhoto{1}x{2}_{3}.png",
                             Application.dataPath,
                             width, height,
                             System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
    }

    public void TakeHiResShot()
    {
        photocap = true;
    }

    void LateUpdate()
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
            RenderTexture.active = null; // JC: added to avoid errors
            Destroy(rt);
            byte[] bytes = screenShot.EncodeToPNG();
            string filename = ScreenShotName(Width, Height);
            System.IO.File.WriteAllBytes(filename, bytes);
            Debug.Log(string.Format("Took screenshot to: {0}", filename));
            photocap = false;
        }
    }
}
