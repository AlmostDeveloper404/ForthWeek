using UnityEngine;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    public Transform coin;

    CoinManager _coinManager;
    
    private void Start()
    {
        _coinManager = CoinManager.instance;
        for (int i = 0; i < 15; i++)
        {
            
            Transform coinGO= Instantiate(coin,new Vector3(Random.Range(-48f, 48f), transform.position.y+1.5f, Random.Range(-48f, 48f)),coin.rotation);
            _coinManager.AddCoin(coinGO);
        }
    }
}
