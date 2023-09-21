using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaracterPlayer : MonoBehaviour
{
    public bool destroi = false;
    public int StartLife = 10;
    private int CharacteristicsLife;
    private bool kill1 = false;


    private void Awake()
    {
        PLay();
    }
    private void PLay()
    {
        kill1 = false;
        CharacteristicsLife = StartLife;

    }
    public void Danege(int Danege)
    {
        if (kill1) return;

        StartLife -= Danege;

        if (CharacteristicsLife > 0)
        {
            Kill();
        }

    }

    private void Kill()
    {
        kill1 = true;
        if (destroi)
        {
            Destroy(gameObject);
        }
    }


}
