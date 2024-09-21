using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerScene : MonoBehaviour
{

//LOAD ENDING SCENE ON TRIGGER
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(1);
        }
    }
} 
