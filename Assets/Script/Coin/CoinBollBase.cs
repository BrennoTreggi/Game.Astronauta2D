using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBollBase : MonoBehaviour
{
    public string comparation = "Player";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag(comparation)) 
        {
            OnCollect();
        
        }

    }
    protected virtual void OnCollect() 
    {
        //Debug.Log("Colllect-okay");
        gameObject.SetActive(false);
        CollectOkay();
    }
    protected virtual void CollectOkay() { }

}
