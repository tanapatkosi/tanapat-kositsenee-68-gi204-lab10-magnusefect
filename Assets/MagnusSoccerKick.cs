using UnityEngine;
public class MagnusSoccerKick : MonoBehaviour
{
    public float kickForce = 20f;

    public float spinAmount = 15f;

    public float magnusStrength = 1f;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && rb != null)
        {
            KickBall();
        }
    }
    void KickBall()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        rb.AddForce(transform.forward * kickForce, ForceMode.Impulse);
        rb.angularVelocity = new Vector3(0, spinAmount, 0);
    }
    void FixedUpdate()
    {
        if (rb != null && rb.linearVelocity.magnitude > 0.1f)
        {
            Vector3 magnusForce = Vector3.Cross(rb.angularVelocity, rb.linearVelocity);
            rb.AddForce(magnusForce * magnusStrength);
        }

    }

}