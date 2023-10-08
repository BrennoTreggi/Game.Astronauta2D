using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWepun : MonoBehaviour
{
    public BaseGun _prefabeGun;
    public Transform _positionDane;
    public float _timedane = .3f;
    public Transform _playerReference;
    private Coroutine _coroutine;

    // Update is called once per frame
    void Update()
    {

       if (Input.GetKeyDown(KeyCode.Q))
       {
          _coroutine = StartCoroutine(StartDane());
       }

       else if (Input.GetKeyUp(KeyCode.Q)) 
       {
            if (_coroutine != null) StopCoroutine(_coroutine);
       }

    }

    IEnumerator StartDane()
    {
        while (true)
        {
            Dane();
            yield return new WaitForSeconds(_timedane);


        }



    }


    public void Dane()
    {
        var daneobject = Instantiate(_prefabeGun);
        daneobject.transform.position = _positionDane.position;
        daneobject._reference = _playerReference.transform.localScale.x;


    }


}
