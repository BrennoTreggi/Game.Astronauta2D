using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Script.Ultts.Singleton;

public class UIGameManeger : Singleton<UIGameManeger>
{

    public TextMeshProUGUI uiTextCoins;
    public static void UpdateTextCoins( string s )
    {

        Instance.uiTextCoins.text = s;

    }
    

}
