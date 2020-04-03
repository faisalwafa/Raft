using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public void SceneLoader (int sceneIndex) {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();

    }
}
