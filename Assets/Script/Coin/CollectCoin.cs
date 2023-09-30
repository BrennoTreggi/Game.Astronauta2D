using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : CoinBollBase
{
    protected override void CollectOkay()
    {
        base.CollectOkay();
        ManegerItensGamer.Instance.AdsCoin();
    }
}
