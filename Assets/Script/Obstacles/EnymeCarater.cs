using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnymeCarater : MonoBehaviour
{
    public int danege = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {


        Debug.Log(collision.transform.name);
        var Health = collision.gameObject.GetComponent<CaracterPlayer>();

        if (Health != null)
        {
            Health.Danege(danege);
        }

    }
}
