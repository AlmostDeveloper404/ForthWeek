using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody _rigidBody;
    [SerializeField] float torqueSpeed = 20f;

    public Transform cam;
    

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _rigidBody.maxAngularVelocity = 500f;   
    }

    private void FixedUpdate()
    {
        _rigidBody.AddTorque(Input.GetAxisRaw("Horizontal")*torqueSpeed* -cam.forward);
        _rigidBody.AddTorque(Input.GetAxisRaw("Vertical") * torqueSpeed*cam.right);
    }
}
