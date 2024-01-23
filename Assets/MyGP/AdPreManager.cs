using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
// Добавьте библиотеку GamePush
using GamePush;

public class AdPreManager : MonoBehaviour
{
    // Показать preloader
    public void ShowPreloader() => GP_Ads.ShowPreloader(OnPreloaderStart, OnPreloaderClose);

    // Начался показ
    private void OnPreloaderStart() => Debug.Log("ON PRELOADER: START");
    // Закончился показ
    private void OnPreloaderClose(bool success) => Debug.Log("ON PRELOADER: CLOSE");

    private void Awake()
    {
        ShowPreloader();
    }
}

