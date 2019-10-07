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


        if (OVRInput.GetDown(flashlightButton))
        {
            FlashlightButtonHit();
        }



    }

    public void FlashlightButtonHit()
    {
        flashlightBulb.enabled = !flashlightBulb.enabled;
        flashlightSound.Play();
    }
}
