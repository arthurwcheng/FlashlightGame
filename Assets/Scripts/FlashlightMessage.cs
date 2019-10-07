using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightMessage : MonoBehaviour
{

    public GameObject teleportMessage;

    // Update is called once per frame
    void Update()
    {

        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            teleportMessage.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
