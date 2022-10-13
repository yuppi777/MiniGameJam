using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PusScore : MonoBehaviour
{
    public ScoreData scoreData;
    [SerializeField] Text scoretext;

    private void Start()
    {
        scoreData = GameObject.Find("ScoreData").GetComponent<ScoreData>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pants")
        {
            Destroy(collision.gameObject);
            scoreData.PlusScore(1);
            scoreData.TextUpdate(scoretext);
        }
    }
}
