using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameManager CurrentGameManager;
    float timeLeft;

    public Text PointsValue;
    public Text TimeValue;

    public void Hit()
    {
        CurrentGameManager.GetPoints();
        PointsValue.text = CurrentGameManager.Points.ToString();
    }
    private void Update()
    {
        ShowTime();
    }
    public void ShowTime()
    {
        timeLeft += Time.deltaTime;
        TimeValue.text = timeLeft.ToString("0.0");
    }
}
