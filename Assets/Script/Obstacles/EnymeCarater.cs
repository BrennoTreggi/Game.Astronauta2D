using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnymeCarater : MonoBehaviour
{
    public int danege = 10;


    public Animator animator;
    public string AnimationEnemy = "Atack";
    private void OnCollisionEnter2D(Collision2D collision)
    {
    
        Debug.Log(collision.transform.name);

        var health = collision.gameObject.GetComponent<CaracterPlayer>();

        if (health != null)
        {
            health.Danege(danege);
            PlayAnimationAtackEnemy();
        }

    }

    private void PlayAnimationAtackEnemy()
    {

        animator.SetTrigger(AnimationEnemy);
    }

 }
