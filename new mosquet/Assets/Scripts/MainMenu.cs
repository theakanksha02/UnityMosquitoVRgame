using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void Selectscene()
    {
        switch (this.gameObject.name)
        {
            case "Scene1Button":
                SceneManager.LoadScene("first");
                break;
            case "Scene2Button":
                SceneManager.LoadScene("second");
                break;

        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("menuscene");
    }


   
    public void QuitGame()
	{
		Debug.Log ("Quit");
		Application.Quit ();
	}

   
}
