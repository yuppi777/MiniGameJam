using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreData : MonoBehaviour
{
    public static int Score;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void PlusScore(int score)
    {
        Score += score;
        Debug.Log(Score);
    }

    public void TextUpdate(Text scoretext)
    {
        scoretext.text = ("Score:")+Score.ToString();
    }
}
