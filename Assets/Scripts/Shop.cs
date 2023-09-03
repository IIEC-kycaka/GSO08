using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    
    public GameObject placeHat;
    public GameObject placeBack;
    public GameObject placeArms;
    public GameObject placeLegs;

    private int i = 0;
    private int countDecorHats;
    private int countDecorBacks;
    private int countDecorArms;
    private int countDecorLegs;


    private void Start()
    {
        countDecorHats = placeHat.transform.childCount - 1;
        countDecorBacks = placeBack.transform.childCount - 1;
        countDecorArms = placeArms.transform.childCount - 1;
        countDecorLegs = placeLegs.transform.childCount - 1;
    }

    public void Next()
    {

    }

    public void Pre()
    {

    }

    public void LoadStart()
    {
        ResetDecor(placeHat, countDecorHats);
        ResetDecor(placeBack, countDecorBacks);
        ResetDecor(placeArms, countDecorArms);
        ResetDecor(placeLegs, countDecorLegs);
        placeHat.transform.GetChild(PlayerPrefs.GetInt("Hat")).gameObject.SetActive(true);
        placeBack.transform.GetChild(PlayerPrefs.GetInt("Back")).gameObject.SetActive(true);
        placeArms.transform.GetChild(PlayerPrefs.GetInt("Arms")).gameObject.SetActive(true);
        placeLegs.transform.GetChild(PlayerPrefs.GetInt("Legs")).gameObject.SetActive(true);
    }

    public void ResetDecor(GameObject placeOnPerk, int count)
    {
        for (int j = 0; j < count; j++)
        {
            placeOnPerk.transform.GetChild(j).gameObject.SetActive(false);
        }
    }

    public void SelectHat(int numberDecor)
    {
        // 0 - none (empty object), 1 - first decor, 2 - second decor...
        ResetDecor(placeHat, countDecorHats);
        PlayerPrefs.SetInt("Hat", numberDecor);
        placeHat.transform.GetChild(numberDecor).gameObject.SetActive(true);
    }

    public void SelectBack(int numberDecor)
    {
        // 0 - none (empty object), 1 - first decor, 2 - second decor...
        ResetDecor(placeBack, countDecorBacks);
        PlayerPrefs.SetInt("Back", numberDecor);
        placeBack.transform.GetChild(numberDecor).gameObject.SetActive(true);
    }

    public void SelectArms(int numberDecor)
    {
        // 0 - none (empty object), 1 - first decor, 2 - second decor...
        ResetDecor(placeArms, countDecorArms);
        PlayerPrefs.SetInt("Arms", numberDecor);
        placeArms.transform.GetChild(numberDecor).gameObject.SetActive(true);
    }

    public void SelectLegs(int numberDecor)
    {
        // 0 - none (empty object), 1 - first decor, 2 - second decor...
        ResetDecor(placeLegs, countDecorLegs);
        PlayerPrefs.SetInt("Legs", numberDecor);
        placeLegs.transform.GetChild(numberDecor).gameObject.SetActive(true);
    }
}
