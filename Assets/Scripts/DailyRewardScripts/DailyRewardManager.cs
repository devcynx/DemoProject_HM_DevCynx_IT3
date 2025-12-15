using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;
using static UnityEngine.Rendering.STP;
using System.Collections.Generic;
using UnityEditor;

public class DailyRewardManager : MonoBehaviour
{
    public DailyReward dailyReward;

    public GameObject dailyRewardPrefab;
    public Transform rewardParent;
    public GameObject dayItemPrefab;
    public Transform contentParent;

    public Button claimButton;
    public TextMeshProUGUI popupText;

    public List<DailyRewardItemUI> allRewardItems;
    private int currentDay;

    int dayCount = 30;

    string[] rewards = new string[30]
    {
        "50 Coins", "75 Coins", "100 Coins",
        "150 Coins", "200 Coins", "250 Coins", "500 Coins", "50 Coins", "75 Coins", "100 Coins",
        "150 Coins", "200 Coins", "250 Coins", "500 Coins", "50 Coins", "75 Coins", "100 Coins",
        "150 Coins", "200 Coins", "250 Coins", "500 Coins", "50 Coins", "75 Coins", "100 Coins",
        "150 Coins", "200 Coins", "250 Coins", "500 Coins", "50 Coins", "75 Coins",
    };

    public Sprite[] icons;

    void Start()
    {
        GenerateRewards();
        //    currentDay = PlayerPrefs.GetInt("DR_CurrentDay", 1);
        //    claimButton.onClick.AddListener(OnClaimButtonPressed);

        //    UpdateUI();
        //}

        //void OnClaimButtonPressed()
        //{
        //    allRewardItems[currentDay - 1].SetClaimed(true);

        //    popupText.text = "Day " + currentDay + " Reward Claimed!";
        //    popupText.gameObject.SetActive(true);

        //    int rewardAmount = dailyReward.data[currentDay - 1].rewards[0].amount;
        //    Debug.Log("Player Received: " + rewardAmount);

        //    currentDay++;
        //    PlayerPrefs.SetInt("DR_CurrentDay", currentDay);
        //    PlayerPrefs.Save();

        //    UpdateUI();
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
    }


    //void UpdateUI()
    //{
    //    for (int i = 0; i < allRewardItems.Count; i++)
    //    {
    //        bool isClaimed = i < currentDay - 1;
    //        allRewardItems[i].SetClaimed(isClaimed);
    //    }
    //}
    //public void OnLockButtonClicked(int dayIndex)
    //{
    //    if (dayIndex == currentDay - 1)
    //    {
    //        ClaimReward();
    //    }

    //}

    //void ClaimReward()
    //{

    //    int index = currentDay - 1;
    //    if (index < 0 || index >= allRewardItems.Count)
    //    {
    //      //  Debug.LogError("ClaimReward(): INDEX OUT OF RANGE → " + index);
    //        return;
    //    }
    //    allRewardItems[index].SetClaimed(true);
    //    popupText.text = "Day " + currentDay + " Reward Claimed!";
    //    popupText.gameObject.SetActive(true);

    //    int rewardAmount = dailyReward.data[index].rewards[0].amount;
    //    Debug.Log("Collected reward: " + rewardAmount);

    //    currentDay++;
    //    PlayerPrefs.SetInt("DR_CurrentDay", currentDay);
    //    PlayerPrefs.Save();

    //    UpdateUI();

    //}
//}