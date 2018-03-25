using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour {

    public void Restart()
    {
        Debug.Log("chk");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        // SceneManager.LoadScene("mos");
        Debug.Log("jj");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
