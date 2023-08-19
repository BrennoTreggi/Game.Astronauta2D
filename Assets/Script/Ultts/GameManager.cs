using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Script.Ultts.Singleton;
using DG.Tweening;

public class GameManager : Singleton<GameManager>
{
    [Header("player")]
    public GameObject playerPrefab;

    [Header("Enemies")]
    public List<GameObject> enemies;

    [Header("References")]
    public Transform startposition;

    [Header("Animation")]
    public float duration = .2f;
    public float delay = .3f;
    public Ease ease = Ease.OutBack;

    private GameObject _CorrentPlayer;
    private void Start()
    {
        init();
    }


    public void init()
    {
        SpeedPlayer();
    }

    private void SpeedPlayer()
    {
        _CorrentPlayer = Instantiate(playerPrefab);
        _CorrentPlayer.transform.position = startposition.transform.position;
        _CorrentPlayer.transform.DOScale(0,duration).SetEase(ease).From().SetDelay(delay);


    }
}
