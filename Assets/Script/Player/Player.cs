using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Player : MonoBehaviour
{
    [Header("SpeedeSetup")]
    public Rigidbody2D myrygibody;
    public Vector2 friction = new Vector2(.1f, 0);
    public float Speed;
    public float ForceJump = 1.5f;
   
    [Header("Animator")]
    public string tringgerplay = "Run";
    public Animator animator;
    public float animationDuration = .1f;

    [Header("AniomationJump")]
    public float ScaleCollider = 0.7f;
    public float JumpScaleY = 1.5f;
    public float JumpScaleX = 0.7f;
    public float jumpduration = .3f;
    public Ease ease = Ease.OutBack;
    public float Speedcaracter;
    private float Speedforce;

    private void Update()
    {
        MyPlayer();
        PlayerJump();
    }

    private void MyPlayer()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Speedforce = Speedcaracter;
            animator.speed = 2;
        }
        else
        {
            Speedforce = Speed;
            animator.speed = 1;

        }



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //myrygibody.MovePosition(myrygibody.position - velocitty * Time.deltaTime);
            myrygibody.velocity = new Vector2(-Speedforce, myrygibody.velocity.y);
            if (myrygibody.transform.localScale.x != -1)
            {
                myrygibody.transform.DOScaleX(-1, animationDuration);
            }
            animator.SetBool(tringgerplay, true);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //myrygibody.MovePosition(myrygibody.position + velocitty * Time.deltaTime);
            myrygibody.velocity = new Vector2(+Speedforce, myrygibody.velocity.y);
            if (myrygibody.transform.localScale.x != 1)
            {
                myrygibody.transform.DOScaleX(1, animationDuration);

            }
            myrygibody.transform.localScale = new Vector3 (1, 1, 1);
            animator.SetBool(tringgerplay, true);

        }
        else
        {
            animator.SetBool(tringgerplay, false);

        }


        if (myrygibody.velocity.x > 0)
        {
            myrygibody.velocity -= friction; 
        }
        else if (myrygibody.velocity.x < 0)
        {
            myrygibody.velocity += friction;

        }

    }
  

    private void PlayerJump()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myrygibody.velocity = Vector2.up * ForceJump;
            myrygibody.transform.localScale = Vector2.one;
            DOTween.Kill(myrygibody.transform);
            DOTween.Kill(myrygibody.transform);
            ScaleJump();
        }

    }
    private void ScaleJump()
    {
        myrygibody.transform.DOScaleX(JumpScaleX, ScaleCollider).SetLoops(1, LoopType.Restart).SetEase(ease);
        myrygibody.transform.DOScaleY(JumpScaleY, jumpduration).SetLoops(2, LoopType.Yoyo).SetEase(ease);
        myrygibody.transform.DOScaleX(JumpScaleX, jumpduration).SetLoops(2, LoopType.Yoyo).SetEase(ease);
    }
}
