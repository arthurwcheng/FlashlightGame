using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightSwitch : MonoBehaviour
{

    public Light flashlightBulb;
    public OVRInput.Button flashlightButton;
    private AudioSource flashlightSound;

    // Start is called before the first frame update
    void Start()
    {
        flashlightBulb.enabled = false;
        flashlightSound = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        // Toggle flashlight on or off
        if (OVRInput.GetDown(flashlightButton))
        {
            flashlightBulb.enabled = !flashlightBulb.enabled;
            flashlightSound.Play();
        }
    }

}
