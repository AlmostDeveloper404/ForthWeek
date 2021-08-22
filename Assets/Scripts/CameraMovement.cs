using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Ball;
    Rigidbody _ballRigidBody;
    float slerpSpeed = 10f;

    public List<Vector3> positions = new List<Vector3>();


    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            positions.Add(Vector3.zero);
        }
        _ballRigidBody = Ball.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        positions.Add(_ballRigidBody.velocity);
        positions.RemoveAt(0);
    }
    private void Update()
    {

        Vector3 sum = Vector3.zero;

        for (int i = 0; i < positions.Count; i++)
        {
            sum += positions[i];
        }

        transform.position = Ball.position;
        transform.rotation = Quaternion.Slerp( transform.rotation,Quaternion.LookRotation(sum),Time.deltaTime*slerpSpeed);

    }
}
