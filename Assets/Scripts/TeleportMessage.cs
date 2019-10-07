using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportMessage : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick) != new Vector2(0,0) || OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick) != new Vector2(0, 0))
        {
            this.gameObject.SetActive(false);
        }
    }
}
