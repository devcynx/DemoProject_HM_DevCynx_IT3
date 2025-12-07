using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DailyRewardDisplay : MonoBehaviour
{
    public DailyReward dailyReward;

    public TextMeshProUGUI DayText;
    public TextMeshProUGUI RewardText;
    public Image Icon;
    void Start()
    {
        DayText.text = dailyReward.DayText;
        RewardText.text = dailyReward.DayText;
        Icon.sprite = dailyReward.Icon;
    }

}
