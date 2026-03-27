using UnityEngine;

public class TorqueRotate : MonoBehaviour
{
    public float torqueForce = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            // หมุนรอบแกน Z
            rb.AddTorque(Vector3.forward * torqueForce);
        }
    }
}