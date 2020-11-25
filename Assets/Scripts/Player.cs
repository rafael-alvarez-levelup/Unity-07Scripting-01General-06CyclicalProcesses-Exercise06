using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 10;

    private Rigidbody myRigidBody;

    private void Awake()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        if (vertical != 0 || horizontal != 0)
        {
            myRigidBody.AddForce(new Vector3(horizontal, 0, vertical) * speed);
        }
    }
}