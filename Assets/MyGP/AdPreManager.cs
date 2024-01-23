using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
// �������� ���������� GamePush
using GamePush;

public class AdPreManager : MonoBehaviour
{
    // �������� preloader
    public void ShowPreloader() => GP_Ads.ShowPreloader(OnPreloaderStart, OnPreloaderClose);

    // ������� �����
    private void OnPreloaderStart() => Debug.Log("ON PRELOADER: START");
    // ���������� �����
    private void OnPreloaderClose(bool success) => Debug.Log("ON PRELOADER: CLOSE");

    private void Awake()
    {
        ShowPreloader();
    }
}

