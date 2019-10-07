using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{

    //This script manages the keypad and acts as a game manager, as the attampted code
    //will determine whether the game is won or not

    //This keypad can be re-used in other scenes, with the required code for the lock modified as desired

    public string code;
    int posInCode;
    int codeLength;
    string codeAttempt = ""; // set as the Numberpad Display Text
    public  List<AudioClip> keypadSounds;
    AudioSource keypadAudio;
    public Text keypadDisplay;
    public Light winGameLight;
    public GameObject winMessage;
    public AudioSource backgroundMusic;

    // Start is called before the first frame update
    void Start()
    {
        winGameLight.enabled = false;
        posInCode = 0;
        codeLength = code.Length;
        keypadAudio = GetComponent<AudioSource>();
    }


    public void SetValue(string value)
    {
        posInCode++;
        keypadAudio.clip = keypadSounds[0];
        keypadAudio.Play();

        if(posInCode <= codeLength)
        {
            codeAttempt += value;
            keypadDisplay.text = codeAttempt;
        }

        //Check code and reset keypad once a full code is attempted
        if (posInCode == codeLength)
        {
            CheckCode();
            codeAttempt = "";
            keypadDisplay.text = codeAttempt;
            posInCode = 0;
        }
    }

    //Method to check code once a full attempted code is input
    void CheckCode()
    {
        if(codeAttempt == code)
        {
            GameWon();
        } else
        {
            FailedCode();
        }
    }

    //If attempted code is wrong, play fail sound and nothing happens
    void FailedCode()
    {
        keypadAudio.clip = keypadSounds[1];
        keypadAudio.Play();
    }

    //If attempted code is correct, game is won. Play win sound, new light is enabled, win message displays
    public void GameWon()
    {
        keypadAudio.clip = keypadSounds[2];
        keypadAudio.Play();
        backgroundMusic.Stop();
        winGameLight.enabled = true;
        winMessage.SetActive(true);
    }
}