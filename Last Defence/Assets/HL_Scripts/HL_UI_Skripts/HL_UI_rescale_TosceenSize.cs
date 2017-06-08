using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HL_UI_rescale_TosceenSize : MonoBehaviour {
    
    GameObject thisObject;
	// Use this for initialization
	void Start ()
    {
        
        thisObject = gameObject;
        var theBarRectTransform = thisObject.transform as RectTransform;
        theBarRectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);
        //theBarRectTransform.sizeDelta = new Vector2(Screen.width, theBarRectTransform.sizeDelta.y);
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
