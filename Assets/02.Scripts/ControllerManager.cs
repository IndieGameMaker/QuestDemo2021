using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerManager : MonoBehaviour
{
    public OVRInput.Controller leftController = OVRInput.Controller.LTouch;
    public OVRInput.Controller rightController = OVRInput.Controller.RTouch;

    void Update()
    {
        // Combine 방식
        /*
            PrimaryIndexTrigger 왼손 트리거 버튼
            SecondaryIndexTrigger 오른손 트리거 버튼
        */
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("왼손 트리거 버튼 클릭");
        }
        if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            Debug.Log("Right Controller Index Trigger Button !!!");
            float value = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger);//0.0f ~ 1.0f
            Debug.Log($"Right Index Trigger {value}");
        }

        // Touch
        if (OVRInput.Get(OVRInput.Touch.PrimaryThumbstick))
        {
            Vector2 pos = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
            Debug.Log($"Thumbstick = {pos.x}/{pos.y}");
        }

        if (OVRInput.Get(OVRInput.Touch.SecondaryIndexTrigger))
        {
            Debug.Log("Right IndexTrigger Touch !!!");
        }

        // Indivisual 방식
        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            Debug.Log("Left HandTrigger Grab");
        }

        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            Debug.Log("Right HandTrigger Grab");
            //Haptic
        }

    }

    
        
}
