using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour
{
    private static float borderX = 0;
    private static float borderY = 0;
    public static float BorderX
    {
        get
        {
            if(borderX == 0)
            {
                var cam = Camera.main;
                borderX = cam.aspect * cam.orthographicSize;
            }
            return borderX;
        }
        private set { }
    }

    public static float BorderY
    {
        get
        {
            if(borderY == 0)
            {
                var cam = Camera.main;
                borderY = cam.orthographicSize;
            }
            return borderY;
        }
        private set { }
    }

}
