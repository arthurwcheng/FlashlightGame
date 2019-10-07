using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]

public class MagicLightSource : MonoBehaviour
{
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
