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
        DayText.text = dailyReward.data[0].DayText;
        RewardText.text = dailyReward.data[0].RewardText;
        Icon.sprite = dailyReward.data[0].Icon;
    }

}
