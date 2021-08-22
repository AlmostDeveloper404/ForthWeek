using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0f,0f, 90f * Time.deltaTime);
    }
}
