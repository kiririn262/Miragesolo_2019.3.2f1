using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //private var Controller;
    // Start is called before the first frame update
    void Start()
    {
        //Controller = GvrControllerInput.GetDevice;
    }

    // Update is called once per frame
    void Update()
    {
        #if UNITY_EDITOR
        if(GvrControllerInput.AppButtonDown)
        //if(GvrControllerInputDevice.GetButtonDown(GvrControllerButton.App))
            {
                Debug.Log("アプリケーションボタンを押したよ！");
            }
        if(GvrControllerInput.HomeButtonDown)
        //if(GvrControllerInputDevice.GetButtonDown(GvrControllerButton.System))
            {
                Debug.Log("ホームボタンを押したよ！");
            }
        if(GvrControllerInput.ClickButtonDown)
        //if(GvrControllerInputDevice.GetButtonDown(GvrControllerButton.TouchPadButton))
            {
                Debug.Log("タッチパッドを押したよ！");
            }
        if(GvrControllerInput.TouchDown)
        //if(GvrControllerInputDevice.GetButtonDown(GvrControllerButton.TouchPadTouch))
            {
                Debug.Log("タッチパッドに触れたよ！");
            }
        #endif
        //Vector2 GvrControllerInput.TouchPos
        //public Vector2 GvrControllerInputDevice.TouchPos;
    }
}
