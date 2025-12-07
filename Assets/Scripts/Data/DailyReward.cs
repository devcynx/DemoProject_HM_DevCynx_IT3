using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Daily Reward", menuName = "DailyReward")]

public class DailyReward : ScriptableObject
{
    public string RewardText;
    public string DayText;
    public Sprite Icon;

    public void Print()
    {
        Debug.Log(RewardText + "5456" + DayText + "Day" + Icon); 
    }
}
