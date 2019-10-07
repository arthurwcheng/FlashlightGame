using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumButtonHit : MonoBehaviour
{

    Keypad keypad;


    void OnTriggerEnter(Collider numButton)
    {
        if(numButton.tag == "Button")
        {
            keypad = numButton.transform.parent.gameObject.GetComponentInParent<Keypad>();

            if(keypad != null)
            {
                string value = numButton.transform.name;
                keypad.SetValue(value);
            }
            
        }
    }
}
