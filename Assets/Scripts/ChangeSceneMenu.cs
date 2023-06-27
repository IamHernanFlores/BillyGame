using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeSceneMenu : MonoBehaviour
{
  public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
