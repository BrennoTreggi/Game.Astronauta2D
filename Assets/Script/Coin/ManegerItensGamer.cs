using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Script.Ultts.Singleton;

public class ManegerItensGamer : Singleton<ManegerItensGamer>
{
    
    public int coins;
    public TextMeshProUGUI TextMeshProUGUI;

    private void Start()
    {
        Reset();

    }

    public void Reset()
    {
        coins = 0;
        UpdateUI();
    }
    public void AdsCoin(int amount = 1) 
    {
        coins += amount;
        UpdateUI();

    }

    private void UpdateUI()
    {
        //TextMeshProUGUI.text = coins.ToString();
        UIGameManeger.UpdateTextCoins(coins.ToString());

    }

}
