using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPrefReward : MonoBehaviour
{
    public void SetDecor()
    {
        PlayerPrefs.SetInt(gameObject.name, 1);
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt(gameObject.name) == 1) gameObject.SetActive(false); 
    }
}
