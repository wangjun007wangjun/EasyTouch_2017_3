using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HedgehogTeam.EasyTouch;

public class EasyTouch4_xDemo : MonoBehaviour {

    //在OnEnable中订阅EasyTouch中事件
    private void OnEnable()
    {
        EasyTouch.On_TouchStart += OnTouchStart;
        EasyTouch.On_TouchUp += OnTouchEnd;
        EasyTouch.On_Swipe += OnSwipe;
        
    }
    //在OnDisable和OnDestroy中取消订阅EasyTouch中对应事件
    private void OnDisable()
    {
        EasyTouch.On_TouchStart -= OnTouchStart;
        EasyTouch.On_TouchUp -= OnTouchEnd;
        EasyTouch.On_Swipe -= OnSwipe;
    }
    private void OnDestroy()
    {
        EasyTouch.On_TouchStart -= OnTouchStart;
        EasyTouch.On_TouchUp -= OnTouchEnd;
        EasyTouch.On_Swipe -= OnSwipe;
    }
    void OnTouchStart(Gesture gesture)
    {
        Debug.Log("OnTouchStart");
        Debug.Log("startPosition:" + gesture.startPosition);
        Debug.Log("TouchCOunt:" + gesture.touchCount);
    }
    void OnTouchEnd(Gesture gesture)
    {
        Debug.Log("OnTouchEnd");
        Debug.Log("actionTime:" + gesture.actionTime);
    }
    void OnSwipe(Gesture gesture)
    {
        Debug.Log("OnSwipe");
        Debug.Log("Type:" + gesture.swipe);
    }
}
