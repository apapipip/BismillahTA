using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCTRL : MonoBehaviour {

    // Load Scene
    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    // Exit 
    public void ExitGame()
    {
        Application.Quit();
    }
}
