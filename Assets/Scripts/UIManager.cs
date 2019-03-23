using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameManager CurrentGameManager;

    public Text PointsValue;
    public void Hit()
    {
        CurrentGameManager.GetPoints();
        PointsValue.text = CurrentGameManager.Points.ToString();
    }
}
