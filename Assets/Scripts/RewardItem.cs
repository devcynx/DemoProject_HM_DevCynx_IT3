using UnityEngine;

[System.Serializable]
public class RewardItem
{
    public string dayLabel;    // "Day 01"
    public int amount;         // coins, etc.
    public string rewardText;  // "50 Coins" (optional)
    public Sprite icon;
    public bool isDefaultLocked; // design-time locked flag (usually true for day>1)
}
