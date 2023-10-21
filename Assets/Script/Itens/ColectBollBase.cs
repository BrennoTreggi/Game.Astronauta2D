using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColectBollBase : MonoBehaviour
{
    public string comparation = "Player";
    public new ParticleSystem particleSystem;
    public float timecoins = 1.34f;
    public GameObject PFB_GameObject;    
    private void Awake()
    {
       // if (particleSystem != null) particleSystem.transform.SetParent(null);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag(comparation)) 
        {
            OnCollect();
        
        }

    }
    protected virtual void OnCollect() 
    {
        if (PFB_GameObject != null) PFB_GameObject.SetActive(false);
        Invoke("vitualObject", timecoins);
        CollectOkay();
    }

    private void vitualObject()
    {

        gameObject.SetActive(false);
    }

    protected virtual void CollectOkay() 
    {

    if (particleSystem != null) particleSystem.Play();


    }

}
