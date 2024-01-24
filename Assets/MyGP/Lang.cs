using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using GamePush;

public class Lang : MonoBehaviour
{
    public TMP_Text textGame;
    public string en;
    public string ru;
    public string es;

    private string lang;

    private void Start()
    {
        lang = GP_Language.Current().ToString();
        Debug.Log("���������� lang = " + lang);
        LangChoice(lang);
    }

    public void LangChoice(string currentLang)
    {
        switch (currentLang)
        {
            case "English":
                // ��� ����������� �����
                textGame.text = en;
                break;
            case "Russian":
                // ��� �������� �����
                textGame.text = ru;
                break;
            case "Spanish":
                // ��� ���������� �����
                textGame.text = es;
                break;
            default:
                // ��� ����������� �����
                textGame.text = en;
                break;
        }
    }
}
