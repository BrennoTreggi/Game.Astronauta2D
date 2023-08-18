using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MenuBottunsManeger : MonoBehaviour
{
    public List<GameObject> Buttons;

    [Header("Animation")]
    public float duration = .2f;
    public float delay = .3f;
    public Ease ease = Ease.OutBack;
    private void OnEnable ()
    {
        HideaBottuns();
        PlayButtons();
    }
    private void HideaBottuns() 
    {
        foreach (var b in Buttons) 
        {
            b.transform.localScale = Vector3.zero;
            b.SetActive(false);
        
        }
    
    }
    private void PlayButtons()
    {
     for (int i = 0; i < Buttons.Count; i++) 
        {
        var b = Buttons[i];
            b.SetActive(true);
            b.transform.DOScale(1, duration).SetDelay(i*delay).SetEase(ease);

        
        }
    
    }

}
