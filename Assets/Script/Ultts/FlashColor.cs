using System.Collections;
using System.Linq;
using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;

public class FlashColor : MonoBehaviour
{
    public List<SpriteRenderer> SpriteRenderers;
    public Color color = Color.red;
    public float duration = .3f;

    private Tween colorTween;

    private void OnValidate()
    {
        SpriteRenderers = new List<SpriteRenderer>();
        foreach (var child in transform.GetComponentsInChildren<SpriteRenderer>())
        {
            SpriteRenderers.Add(child);

        }



    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Flash();
        }

    }

    public void Flash()
    {


        if (colorTween != null)
        {
            colorTween.Kill();
            SpriteRenderers.ForEach(e => e.color = Color.white);

        }

        foreach (var s in SpriteRenderers)
        {

          colorTween = s.DOColor(color, duration)
                .SetLoops(2, LoopType.Yoyo);
        }


    }






}
