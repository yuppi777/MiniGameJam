using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    [SerializeField] string _scenename; 
   public void SceneChange(string scenename)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scenename);
    }
    public void SceneCha()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_scenename);
    }
}
