using UnityEngine;

// �������� ���������� GamePush
using GamePush;

public class AdRewardManager : MonoBehaviour
{
    public GameObject toRewardPanel;
    public GameObject afterRewardPanel;



    // �������� rewarded video
    public void ShowRewarded() => GP_Ads.ShowRewarded("COINS", OnRewardedReward, OnRewardedStart, OnRewardedClose);


    // ������� �����
    private void OnRewardedStart() => Debug.Log("ON REWARDED: START");
    // �������� �������
    private void OnRewardedReward(string value)
    {
        if (value == "COINS")
            PlayerPrefs.SetInt("ShowReward", 1);

        afterRewardPanel.SetActive(true);
        toRewardPanel.SetActive(false);

    }

    // ���������� �����
    private void OnRewardedClose(bool success) 
    {

    } 
}

