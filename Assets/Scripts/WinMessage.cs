using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMessage : MonoBehaviour
{
    //This is attached to the message when the game is won. Allows the player to restart the game.

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Hand") { 
            SceneManager.LoadScene("main");
        }
    }
}
