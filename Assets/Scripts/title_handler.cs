using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title_handler : MonoBehaviour
{
    public void loadNextScene(string sceneName)
    {
        if (sceneName == "Options")
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        else
            SceneManager.LoadScene(sceneName);
    }
}
