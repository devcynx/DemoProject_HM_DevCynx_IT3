using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Daily Reward", menuName = "DailyReward")]

[Serializable]
public class DailyRewardData
{
    [Header("Reward Data")]
    public string RewardText;
    public string DayText;
    public Sprite Icon;

    public RewardItem[] rewards;

}
public class DailyReward : ScriptableObject
{

    public DailyRewardData[] data;
    public void Print()
    {
        Debug.Log(data[0] + "5456" + data[0].DayText + "Day" + data[0].Icon); 
    }
}
