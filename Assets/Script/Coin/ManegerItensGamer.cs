using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Script.Ultts.Singleton;

public class ManegerItensGamer : Singleton<ManegerItensGamer>
{
    
    public int coins;

    private void Start()
    {
        Reset();

    }

    public void Reset()
    {
        coins = 0;
    }
    public void AdsCoin(int amount = 1) 
    {
        coins += amount;
    
    }
}
