using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightColourManager : MonoBehaviour
{

    public List<Color> flashlightColours;
    Renderer flashlightPanelColour;
    AudioSource flashlightAudio;
    public Light flashlight;
    int currentColour = 0;
    public MagicLightSource magicRevealer;


    // Start is called before the first frame update
    void Start()
    {
        flashlightAudio = GetComponent<AudioSource>();
        flashlightPanelColour = GetComponent<Renderer>();
    }

    // If the left colour change button is hit
    public void FlashColourLeft()
    {
        flashlightAudio.Play();
        currentColour--;
        if(currentColour < 0)
        {
            currentColour = flashlightColours.Count - 1;
        }
        flashlightPanelColour.material.color = flashlightColours[currentColour];
        flashlight.color = flashlightColours[currentColour];
        magicRevealer.UpdateColour(currentColour);
    }

    //If the right colour change button is hit
    public void FlashColourRight()
    {
        flashlightAudio.Play();
        currentColour++;
        if(currentColour > flashlightColours.Count - 1)
        {
            currentColour = 0;
        }
        flashlightPanelColour.material.color = flashlightColours[currentColour];
        flashlight.color = flashlightColours[currentColour];
        magicRevealer.UpdateColour(currentColour);
    }
}
