using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Right : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (OVRInput.GetUp(OVRInput.Button.One))
        {
            Debug.Log("A");
        }
        //Debug.Log(Camera.main.transform.localPosition);
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            //TeleportButtonDownEvent();
        }
        if (OVRInput.GetUp(OVRInput.Button.Two))
        {
            Debug.Log("B");
        }

        if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            //TriggerButtonEvent();
            //Debug.Log("트리거 오");
        }
        if (OVRInput.GetUp(OVRInput.Button.SecondaryIndexTrigger))
        {
            //TriggerButtonUpEvent();
            Debug.Log("트리거 오");
        }

        //0504
        if (OVRInput.GetUp(OVRInput.Button.SecondaryThumbstickLeft))
        {
            //ThumbstickEvent(Dir.Left);
        }
        if (OVRInput.GetUp(OVRInput.Button.SecondaryThumbstickRight))
        {
            //ThumbstickEvent(Dir.Right);
        }

        //디버그용
        //if (Switch == true)
        //{
        //    Switch = false;
        //    Target.OnClickEvents();
        //}
    }
}
