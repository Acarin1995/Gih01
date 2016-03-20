using UnityEngine;
using System.Collections;

public class TouchManager : MonoBehaviour {

    public static bool guiTouch = false;
    public void TouchInput(GUITexture texture)
    {
        if(texture.HitTest(Input.GetTouch(0).position))
        {
            switch(Input.GetTouch(0).phase)
            {
                case TouchPhase.Began:
                    SendMessage("OnFirstTouchBegan");
                    SendMessage("OnFirstTouch");
                    guiTouch = true;
                    break;
                case TouchPhase.Stationary:
                    SendMessage("OnFirstTouchStationary");
                    SendMessage("OnFirstTouch");
                    guiTouch = true;
                    break;
                case TouchPhase.Moved:
                    SendMessage("OnFirstTouchMoved");
                    SendMessage("OnFirstTouch");
                    guiTouch = true;
                    break;
                case TouchPhase.Ended:
                    SendMessage("OnFirstTouchEnded");
                    SendMessage("OnFirstTouch");
                    guiTouch = false;
                    break;
            }
        }
        if (texture.HitTest(Input.GetTouch(1).position))
        {
            switch (Input.GetTouch(1).phase)
            {
                case TouchPhase.Began:
                    SendMessage("OnSecondaryTouchBegan");
                    SendMessage("OnSecondaryTouch");
                    break;
                case TouchPhase.Stationary:
                    SendMessage("OnSecondaryStationary");
                    SendMessage("OnSecondaryTouch");
                    break;
                case TouchPhase.Moved:
                    SendMessage("OnSecondaryTouchMoved");
                    SendMessage("OnSecondaryTouch");
                    break;
                case TouchPhase.Ended:
                    SendMessage("OnSecondaryTouchEnded");
                    SendMessage("OnSecondaryTouch");
                    break;
            }
        }

    }
}
