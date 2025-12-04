using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class DailyRewardManager : MonoBehaviour
{
    public GameObject dailyRewardPrefab;
    public Transform rewardParent;

    int dayCount = 7;

    string[] rewards = new string[7]
    {
        "50 Coins", "75 Coins", "100 Coins",
        "150 Coins", "200 Coins", "250 Coins", "500 Coins"
    };

    public Sprite[] icons;

    void Start()
    {
        GenerateRewards();
    }

    void GenerateRewards()
    {

        for (int i = 0; i < dayCount; i++)
        {
            GameObject item = Instantiate(dailyRewardPrefab, rewardParent);
            Debug.Log(item.name);
            item.name = "Day " + (i + 1);
                 Debug.Log(item.name);
            item.transform.Find("DayText").GetComponent<TextMeshProUGUI>().text ="Day 0" + (i+1).ToString();
            item.transform.Find("RewardText").GetComponent<TextMeshProUGUI>().text = rewards[i];
            item.transform.Find("Icon").GetComponent<Image>().sprite = icons[i];
        }
    }
}
