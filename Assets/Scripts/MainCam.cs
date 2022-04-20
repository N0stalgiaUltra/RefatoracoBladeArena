 using UnityEngine;
 using System.Collections;
 using System.Collections.Generic;

 public class MainCam : MonoBehaviour
 {
    
    
    
    public bool maintainWidth = true;
    [Range(-1, 1)]
    public int adaptPosition;
    float defaultWeidth, defaultHeight;
   
    Vector3 CamPos;
    public Camera Cam;

    void Start () {
            //Debug.Log(Cam.aspect);
            //Debug.Log(Cam.orthographicSize);
            CamPos = Cam.transform.position;
            defaultHeight = Cam.orthographicSize;
            defaultWeidth = Cam.orthographicSize * Cam.aspect;
    }
    void Update () 
    {
        if(maintainWidth)
        {
            Cam.orthographicSize = defaultWeidth / Cam.aspect;
            Cam.transform.position = new Vector3(CamPos.x, adaptPosition * (defaultHeight - Cam.orthographicSize), CamPos.z);
            //(0,0,0)
        }
        else
        {
            Cam.transform.position = new Vector3(adaptPosition * (defaultWeidth - Cam.orthographicSize*Cam.aspect), CamPos.y, CamPos.z);
        }
    }
    /*
    public float targetaspect;
    void Start (){
        // set the desired aspect ratio (the values in this example are
        // hard-coded for 16:9, but you could make them into public
        // variables instead so you can set them at design time)
        

        // determine the game window's current aspect ratio
        float windowaspect = (float)Screen.width / (float)Screen.height;

        // current viewport height should be scaled by this amount
        float scaleheight = windowaspect / targetaspect;

        // obtain camera component so we can modify its viewport
        Camera camera = GetComponent<Camera>();

        // if scaled height is less than current height, add letterbox
        if (scaleheight < 1.0f)
        {  
            Rect rect = camera.rect;

            rect.width = 1.0f;
            rect.height = scaleheight;
            rect.x = 0;
            rect.y = (1.0f - scaleheight) / 2.0f;
            
            camera.rect = rect;
        }
        else // add pillarbox
        {
            float scalewidth = 1.0f / scaleheight;

            Rect rect = camera.rect;

            rect.width = scalewidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scalewidth) / 2.0f;
            rect.y = 0;

            camera.rect = rect;
        }
    }*/
}
 