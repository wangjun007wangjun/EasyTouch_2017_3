using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HedgehogTeam.EasyTouch;

public class EasyTouch5_xDemo : MonoBehaviour {
	
	// EasyTouch5.x版本中新特性可以不用书写订阅事件
	void Update () {
        //通过EasyTouch.current获取玩家输入的手势
        Gesture currentGesture = EasyTouch.current;
        //将输入的手势与系统的手势类型进行对比
        //当没有输入时（没有触摸屏幕时）EasyTouch.current会返回null
        if(currentGesture!=null&& EasyTouch.EvtType.On_TouchStart==currentGesture.type)
        {
            //写法1：直接书写游戏逻辑
            Debug.Log("OnTouchStart");
            Debug.Log("startPosition:" + currentGesture.startPosition);
            Debug.Log("TouchCOunt:" + currentGesture.touchCount);
        }
        if (currentGesture != null && EasyTouch.EvtType.On_TouchUp == currentGesture.type)
        {
            //写法2:将游戏逻辑放于一个方法中，进行调用
            OnTouchEnd(currentGesture);
        }
        if (currentGesture != null && EasyTouch.EvtType.On_TouchStart == currentGesture.type)
        {
            OnSwipe(currentGesture);
        }
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
