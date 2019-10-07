using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChangeButtonHit : MonoBehaviour
{
    FlashlightColourManager flashlight;


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
