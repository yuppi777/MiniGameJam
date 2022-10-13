using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Titol : MonoBehaviour
{
    [SerializeField] SceneManager sceneManager;
   public void Chnangee()
    {
        sceneManager.SceneChange("Main");
    }
}
