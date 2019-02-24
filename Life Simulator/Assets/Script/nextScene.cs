using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    public void sceneLoader(int sceneIndex)
    {
    	SceneManager.LoadScene(sceneIndex);
    }

    public void quit()
    {
    	Application.Quit();
    }
}
