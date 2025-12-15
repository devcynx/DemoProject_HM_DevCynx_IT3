using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DailyRewardItemUI : MonoBehaviour
{
    public TextMeshProUGUI dayText;
    public TextMeshProUGUI rewardText;
    public Image rewardIcon;

    public GameObject claimedOverlay;   
    public Button lockButton;
    public Button claimButton;

    public GameObject lockedIcon;
    public GameObject claimedTick;
    public int dayIndex;

    public void SetClaimed(bool claimed)
    {
        claimedTick.SetActive(claimed);
        claimButton.gameObject.SetActive(!claimed);
        lockedIcon.SetActive(false);
        claimedOverlay.SetActive(claimed);

        //rewardIcon.SetActive(!claimed);     
    }

    public void SetLocked(bool locked)
    {
        lockedIcon.SetActive(locked);
        claimButton.gameObject.SetActive(!locked);
        claimedTick.SetActive(false);
    }

    public void Setup(int index)
    {
        dayIndex = index;
    }
}
