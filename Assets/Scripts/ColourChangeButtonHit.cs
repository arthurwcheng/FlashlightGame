using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChangeButtonHit : MonoBehaviour
{
    // This script is attached to the flashlight colour changing buttons.

    FlashlightColourManager flashlight; //attach gameobject with the FlashlightColourManager component


    private void OnTriggerEnter(Collider col)
    {
        flashlight = col.transform.parent.GetComponentInParent<FlashlightColourManager>();

        if(flashlight != null)
        {
            if (col.tag == "FlashlightLeft")
            {
                flashlight.FlashColourLeft();
            } else if(col.tag == "FlashlightRight")
            {
                flashlight.FlashColourRight();
            }
        }

    }
}
