using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpDate : MonoBehaviour
{
   
    [SerializeField] Text scoreText;


    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Update is called once per frame
    void Update()
    {

        scoreText.text ="Score"+" "+ ScoreData.Score.ToString();
    }
}
