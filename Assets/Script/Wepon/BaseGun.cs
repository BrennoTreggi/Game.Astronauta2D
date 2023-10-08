using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGun : MonoBehaviour
{
    public Vector3 _direction;
    public float destroy = 2f;
    public float _reference = 1f;
    public int damegeAmount = 1;
    private void Awake()
    {
        Destroy(gameObject, destroy);

    }
    private void Update()
    {
        transform.Translate(_direction * Time.deltaTime * _reference);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.transform.GetComponent<EnymeCarater>();

        if (enemy != null) 
        {
            enemy.Danege(damegeAmount);
            Destroy(gameObject);
        
        }


    }


}
