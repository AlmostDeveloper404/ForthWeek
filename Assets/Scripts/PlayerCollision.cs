using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    CoinManager _coinManager;

    private void Start()
    {
        _coinManager = CoinManager.instance;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            _coinManager.RemoveCoin(other.transform);
            Destroy(other.gameObject);
        }
    }
}
