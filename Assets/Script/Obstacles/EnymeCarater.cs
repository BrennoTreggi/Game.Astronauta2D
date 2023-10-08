using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnymeCarater : MonoBehaviour
{
    public HealthBase healthBase;
    public int danege = 10;
    public Animator animator;
    public string AnimationEnemy = "Atack";
    public string Tringerkill = "Detch";
    public float timetabedestroy = 1f;
    private void Awake()
    {
         if (healthBase != null)
        {
            healthBase.Onkill += OnEnimyKill;
        }
    }

    private void OnEnimyKill()
    {
        healthBase.Onkill -= OnEnimyKill;
        PlayAnimationDetchh();
        Destroy(gameObject, timetabedestroy);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    
        Debug.Log(collision.transform.name);

        var health = collision.gameObject.GetComponent<HealthBase>();

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
    private void PlayAnimationDetchh()
    {
        animator.SetTrigger(Tringerkill);

    }

    public void Danege(int amount)
    {
        healthBase.Danege(amount);
    }
}
