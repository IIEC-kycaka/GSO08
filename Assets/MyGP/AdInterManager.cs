using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
// Добавьте библиотеку GamePush
using GamePush;

public class AdInterManager : MonoBehaviour
{
    public GameObject panelLoose;
    public GameObject panelWin;
    //public GameObject panelReward;
    // public Text textCoin;
    public GameObject adsWinError;
    public GameObject adsLoseError;
    public TMP_Text adsWinText;
    public TMP_Text adsLoseText;
    public Button restartWin;
    public Button nextWin;
    public Button restartLose;
    public Button outScene;
    //private int coin;
    private int i;

    IEnumerator Pause()
    {
        restartWin.gameObject.SetActive(false);
        nextWin.gameObject.SetActive(false);
        restartLose.gameObject.SetActive(false);
        outScene.gameObject.SetActive(false);
        adsWinText.text = "Отлично! Подготовим следующую трассу к заезду!";
        adsLoseText.text = "Сейчас починим и можно попробовать ещё раз!";
        yield return new WaitForSeconds(0.5f);
        adsWinText.text = "Отлично! Подготовим следующую трассу к заезду!";
        adsLoseText.text = "Сейчас починим и можно попробовать ещё раз!";
        yield return new WaitForSeconds(1f);
        adsWinText.text = "Отлично! Подготовим следующую трассу к заезду!";
        adsLoseText.text = "Сейчас починим и можно попробовать ещё раз!";
        yield return new WaitForSeconds(1f);
        adsWinText.text = "Трасса готова! Можно ехать!";
        adsLoseText.text = "Всё готово! Можно ехать!";
        yield return new WaitForSeconds(1f);
        ShowInterstitial();
        //CheckAdsWork();
        // adsWinText.text = "";
        //adsLoseText.text = "";
        restartWin.gameObject.SetActive(true);
        nextWin.gameObject.SetActive(true);
        restartLose.gameObject.SetActive(true);
        outScene.gameObject.SetActive(true);
    }

    public void ShowInterstitial()
    {
        GP_Ads.ShowFullscreen();
    }
    private void Update()
    {

        if ((panelLoose.activeSelf || panelWin.activeSelf) && i == 0)
        {
            i += 1;
            StartCoroutine("Pause");
        }
        if (panelWin.activeSelf) panelLoose.SetActive(false);
    }
}

