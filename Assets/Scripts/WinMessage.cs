using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMessage : MonoBehaviour
{


    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Hand") { 
            SceneManager.LoadScene("main");
        }
    }
}
