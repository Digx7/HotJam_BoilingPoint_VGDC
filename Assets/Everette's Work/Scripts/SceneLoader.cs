using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string newSceneName;

    public void _LoadScene(){
      SceneManager.LoadScene(newSceneName);
    }

    public void QuitApp(){
      Application.Quit();
    }
}
