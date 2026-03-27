using UnityEngine;

public class AngularVelocity : MonoBehaviour
{
    public float speed = 0f;
    public float acceleration = 200f;
    public float damping = 0.95f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            speed += acceleration * Time.deltaTime;
        }
        else
        {
            speed *= damping;
        }

        transform.Rotate(0f, speed * Time.deltaTime, 0f);
    }
}