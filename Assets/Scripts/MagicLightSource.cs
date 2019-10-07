using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]

public class MagicLightSource : MonoBehaviour
{

    //Attach this script to the desired flashlight, with various materials desired to be magically revealed dependent on the current flashlight colour
    //The materials in this array should correspond the array in the FlashlightColourManager script
    //Eg Element 0 of the FlashlightColourManager's Color array will reveal Material 0 in this script's Material array

    public List<Material> magicMaterials;
    public Light flashlight;
    int magicRevealNumber;

    public void UpdateColour(int currentColour)
    {
        magicRevealNumber = currentColour;
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if flashlight is on, and passes in the required properties for the 'magic' revealing Shader script to work
        if (flashlight.enabled)
        {
            magicMaterials[magicRevealNumber].SetVector("_LightPosition", flashlight.transform.position);
            magicMaterials[magicRevealNumber].SetVector("_LightDirection", -flashlight.transform.forward);
            magicMaterials[magicRevealNumber].SetFloat("_LightAngle", flashlight.spotAngle);

        } else
        {
            magicMaterials[magicRevealNumber].SetVector("_LightDirection", Vector3.zero);
        }
    }


    
}
