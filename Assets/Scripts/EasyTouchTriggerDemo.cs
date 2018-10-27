using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HedgehogTeam.EasyTouch;

public class EasyTouchTriggerDemo : MonoBehaviour {

	public void PrintMsg(GameObject go)
    {
        if(go==null)
        {
            Debug.Log("NULL");
        }
        else
        {
            Debug.Log(go.name);
        }
    }
    public void PrintOK()
    {
        Debug.Log("OK");
    }
    public void Print2()
    {
        Debug.Log("Cube2");
    }
}
