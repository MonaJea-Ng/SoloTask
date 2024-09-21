using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{ 
    ///private bool _Playthegame;
    private void Update()
    {
        ///StartCoroutine(playthegame());

    }
   public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    
    }
///9
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
    ///private IEnumerator playthegame()
    ///{
        ///if (!_Playthegame)
        ///{
            ///yield return new WaitForSeconds(3);
            ///SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
        ///}

       /// _Playthegame = !_Playthegame;
   /// }

}
