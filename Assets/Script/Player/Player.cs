using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Player : MonoBehaviour
{
    public HealthBase HealthBase;
    public Rigidbody2D myrygibody;

    [Header("Setup")]
    public SO_Player SO_Player;

    //public Animator animator;
    public float Speedcaracter;
    private float Speedforce;
    private Animator myAnimator;

    private void Awake()
    {
       myAnimator = Instantiate(SO_Player.player, transform);


       if (HealthBase != null)
        {
           HealthBase.Onkill += OnPlayer;
            
        }
    }

    private void OnPlayer()
    {
        HealthBase.Onkill -= OnPlayer;
        myAnimator.SetTrigger(SO_Player.tringgerDetch);
    }

    private void Update()
    {
        MyPlayer();
        PlayerJump();
    }

    private void MyPlayer()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Speedforce = SO_Player.speedRun;
            myAnimator.speed = 2;
        }
        else
        {
            Speedforce = SO_Player.Speed;
            myAnimator.speed = 1;

        }



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //myrygibody.MovePosition(myrygibody.position - velocitty * Time.deltaTime);
            myrygibody.velocity = new Vector2(-Speedforce, myrygibody.velocity.y);
            if (myrygibody.transform.localScale.x != -1)
            {
                myrygibody.transform.DOScaleX(-1, SO_Player.animationDuration);
            }
            myAnimator.SetBool(SO_Player.tringgerplay, true);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //myrygibody.MovePosition(myrygibody.position + velocitty * Time.deltaTime);
            myrygibody.velocity = new Vector2(+Speedforce, myrygibody.velocity.y);
            if (myrygibody.transform.localScale.x != 1)
            {
                myrygibody.transform.DOScaleX(1, SO_Player.animationDuration);

            }
            myrygibody.transform.localScale = new Vector3 (1, 1, 1);
            myAnimator.SetBool(SO_Player.tringgerplay, true);

        }
        else
        {
            myAnimator.SetBool(SO_Player.tringgerplay, false);

        }


        if (myrygibody.velocity.x > 0)
        {
            myrygibody.velocity -= SO_Player.friction; 
        }
        else if (myrygibody.velocity.x < 0)
        {
            myrygibody.velocity += SO_Player.friction;

        }

    }
  

    private void PlayerJump()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myrygibody.velocity = Vector2.up * SO_Player.ForceJump;
            myrygibody.transform.localScale = Vector2.one;
            DOTween.Kill(myrygibody.transform);
            DOTween.Kill(myrygibody.transform);
            ScaleJump();
        }

    }
    private void ScaleJump()
    {
        myrygibody.transform.DOScaleX(SO_Player.JumpScaleX, SO_Player.jumpduration).SetLoops(1, LoopType.Restart).SetEase(SO_Player.ease);
        myrygibody.transform.DOScaleY(SO_Player.JumpScaleY, SO_Player.jumpduration).SetLoops(2, LoopType.Yoyo).SetEase(SO_Player.ease);
       // myrygibody.transform.DOScaleX(JumpScaleX, jumpduration).SetLoops(2, LoopType.Yoyo).SetEase(ease);
    }

    public void Destroylle()
    {
        Destroy(gameObject);
    }


}
