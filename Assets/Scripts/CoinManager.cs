using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager :MonoBehaviour
{
    public List<Transform> coins = new List<Transform>();

    #region Singleton
    public static CoinManager instance;

    private void Awake()
    {
        if (instance!=null)
        {
            return;
        }
        instance = this;
    }
    #endregion
    public void AddCoin(Transform coin)
    {
        coins.Add(coin);
        
    }
    public void RemoveCoin(Transform coin)
    {
        coins.Remove(coin);
    }


    private void Update()
    {
        if (coins.Count==0)
        {
            GameManager.instance.Win();
        }
    }
    public Vector3 NearestCoin(Transform ball)
    {

        float nearestCoinDistance=Mathf.Infinity;

        Transform nearestTarget = null;
        for (int i = 0; i < coins.Count; i++)
        {
            float distance = Vector3.Distance(ball.position,coins[i].position);
            if (distance<nearestCoinDistance)
            {
                nearestCoinDistance = distance;
                nearestTarget = coins[i];
            }
        }

        return nearestTarget.position;
    }
}
