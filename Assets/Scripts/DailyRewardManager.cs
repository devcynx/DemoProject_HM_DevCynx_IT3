using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;
using static UnityEngine.Rendering.STP;

public class DailyRewardManager : MonoBehaviour
{
    public GameObject dailyRewardPrefab;
    public Transform rewardParent;

    //public DailyRewardsConfig config;
    public GameObject dayItemPrefab; 
    public Transform contentParent;

    int dayCount = 30;

    string[] rewards = new string[30]
    {
        "50 Coins", "75 Coins", "100 Coins",
        "150 Coins", "200 Coins", "250 Coins", "500 Coins", "50 Coins", "75 Coins", "100 Coins",
        "150 Coins", "200 Coins", "250 Coins", "500 Coins", "50 Coins", "75 Coins", "100 Coins",
        "150 Coins", "200 Coins", "250 Coins", "500 Coins", "50 Coins", "75 Coins", "100 Coins",
        "150 Coins", "200 Coins", "250 Coins", "500 Coins", "50 Coins", "75 Coins"
    };

    public Sprite[] icons;

    void Start()
    {
        GenerateRewards();
        //LoadRewards();
    }

    void GenerateRewards()
    {

        for (int i = 0; i < dayCount; i++)
        {
            GameObject item = Instantiate(dailyRewardPrefab, rewardParent);
            Debug.Log(item.name);
            item.name = "Day " + (i + 1);
            Debug.Log(item.name);
            item.transform.Find("DayText").GetComponent<TextMeshProUGUI>().text = "Day 0" + (i + 1).ToString();
            item.transform.Find("RewardText").GetComponent<TextMeshProUGUI>().text = rewards[i];
            item.transform.Find("Icon").GetComponent<Image>().sprite = icons[i];
        }
    }
    //void LoadRewards()
    //{
    //    for (int i = 0; i < config.rewards.Length; i++)
    //    {
    //        var data = config.rewards[i];

    //        GameObject obj = Instantiate(dayItemPrefab, contentParent);

    //        DailyRewardItemUI ui = obj.GetComponent<DailyRewardItemUI>();

    //        ui.Setup(
    //            data.dayLabel,
    //            data.rewardText,
    //            data.icon,
    //            i);   // day index for saving

    //    }
    //}
}
