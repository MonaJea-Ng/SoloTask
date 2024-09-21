using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
   public void PlayGame ()
    {
        SceneManager.LoadScene(0);///(SceneManager.GetActiveScene().buildIndex + 0);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}
