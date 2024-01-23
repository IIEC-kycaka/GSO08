using UnityEngine;

// Добавьте библиотеку GamePush
using GamePush;

public class AdRewardManager : MonoBehaviour
{
    public GameObject toRewardPanel;
    public GameObject afterRewardPanel;



    // Показать rewarded video
    public void ShowRewarded() => GP_Ads.ShowRewarded("COINS", OnRewardedReward, OnRewardedStart, OnRewardedClose);


    // Начался показ
    private void OnRewardedStart() => Debug.Log("ON REWARDED: START");
    // Получена награда
    private void OnRewardedReward(string value)
    {
        if (value == "COINS")
            PlayerPrefs.SetInt("ShowReward", 1);

        afterRewardPanel.SetActive(true);
        toRewardPanel.SetActive(false);

    }

    // Закончился показ
    private void OnRewardedClose(bool success) 
    {

    } 
}

