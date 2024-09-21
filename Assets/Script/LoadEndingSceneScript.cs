using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEndingSceneScript : MonoBehaviour
{

//LOAD ENDING SCENE ON TRIGGER
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
        }
    }
} 
