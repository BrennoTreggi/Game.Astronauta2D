using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBase : MonoBehaviour
{
    public Action Onkill;
    public float timekill = 5f;
    public bool destroy = false;
    public int StartLife = 10;
    private int CharacteristicsLife;
    private bool kill1 = false;

    [SerializeField] private FlashColor FlashColor;

    private void Awake()
    {
        PLay();

        if (FlashColor == null) 
        {
        FlashColor = GetComponent<FlashColor>();
        
        }
        
    }
    private void PLay()
    {
        kill1 = false;
        CharacteristicsLife = StartLife;

    }
    public void Danege(int Danege)
    {
        if (kill1) return;

        CharacteristicsLife -= Danege;

        if (CharacteristicsLife <= 0)
        {
            Kill();
        }

        if(FlashColor != null) 
        {
            FlashColor.Flash();
        
        }



    }

    private void Kill()
    {
        kill1 = true;
        if (destroy)
        {
            Destroy(gameObject, timekill);
        }
        Onkill?.Invoke();
    }


}
