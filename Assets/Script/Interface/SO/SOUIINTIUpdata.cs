using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SOUIINTIUpdata : MonoBehaviour
{
    public SOinti sOinti;
    public TextMeshProUGUI uiText;

    void Start()
    {
     
        uiText.text = sOinti.valor.ToString();
    }

     void Update()
    {
        uiText.text = sOinti.valor.ToString();


    }

}
