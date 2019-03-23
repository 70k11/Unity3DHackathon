using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameData CurrentGameData;

    public delegate void DataChanged();
    public static event DataChanged OnDataChanged;

    public int Points
    {
        get
        {
            return CurrentGameData.Points;
        }
        private set
        {
            CurrentGameData.Points = value;
            if (OnDataChanged != null)
            {
                OnDataChanged();
            }
        }
    }

    public void GetPoints()
    {
        Points++;
        if (OnDataChanged != null)
        {
            OnDataChanged();
        }
    }

}
