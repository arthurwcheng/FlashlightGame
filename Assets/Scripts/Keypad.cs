using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{

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

    void FailedCode()
    {
        keypadAudio.clip = keypadSounds[1];
        keypadAudio.Play();
    }

    public void GameWon()
    {
        keypadAudio.clip = keypadSounds[2];
        keypadAudio.Play();
        backgroundMusic.Stop();
        winGameLight.enabled = true;
        winMessage.SetActive(true);
    }
}