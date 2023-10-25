using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : ColectBollBase
{
    protected override void CollectOkay()
    {
        base.CollectOkay();
        ManegerItensGamer.Instance.AdsCoin();
        ManegerItensGamer.Instance.Adsfoguete();



    }
}
