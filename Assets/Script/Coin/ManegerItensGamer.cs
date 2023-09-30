using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManegerItensGamer : MonoBehaviour
{
    public static ManegerItensGamer Instance;
    public int coins;

   
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);    
    }
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
