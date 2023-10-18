using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


[CreateAssetMenu]
public class SO_Player : ScriptableObject
{
    public SO_String Name;
    public Animator player;

    [Header("SpeedeSetup")]
    public Vector2 friction = new Vector2(.1f, 0);
    public float Speed;
    public float speedRun;
    public float ForceJump = 1.5f;

    [Header("AniomationJump")]
     public float ScaleCollider = 0.7f;
     public float JumpScaleY = 1.5f;
     public float JumpScaleX = 0.7f;
     public float jumpduration = .3f;
    public Ease ease = Ease.OutBack;
     

    [Header("Animator")]
    public string tringgerplay = "Run";
    public string tringgerDetch = "Detch";
    public float animationDuration = .1f;

}
