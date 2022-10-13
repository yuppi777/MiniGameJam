using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerMaster : MonoBehaviour
{
    [SerializeField] Text timer;
    [SerializeField] SceneManager sceneManager;

    private float timeLimit;
    private float moveTime;

    public bool isGameOver = false;

    void Start()
    {
        timeLimit = 60;
        moveTime = timeLimit;
        timer.text = timeLimit.ToString();
    }
    public bool TimeController(float deltaTime)
    {
        moveTime = moveTime - deltaTime;
        timer.text = Mathf.CeilToInt(moveTime).ToString();
        if (moveTime <= 0.0f)
        {
            timer.text = ("0");
            return false;
        }
        return true;
    }
    public void SetReStartTime()
    {
        moveTime = timeLimit;
    }
    private void Update()
    {
        if (!TimeController(Time.deltaTime))
        {
            
            isGameOver = true;
        }

        if (isGameOver)
        {
            sceneManager.SceneChange("END");
        }
    }
}
