using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerToNearestCoin : MonoBehaviour
{
    public Transform Ball;

    [SerializeField]Vector3 offset;
    float slerpSpeed = 15f;

    CoinManager _coinManager;

    private void Start()
    {
        _coinManager = CoinManager.instance;
    }
    private void Update()
    {
        transform.position = Ball.position+ offset;
        Vector3 dir = _coinManager.NearestCoin(Ball)- transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(dir.x,0f,dir.z));
        transform.rotation =Quaternion.Slerp( transform.rotation,lookRotation,slerpSpeed*Time.deltaTime);
    }
}
