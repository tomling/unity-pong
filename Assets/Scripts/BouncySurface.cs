using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength = 10f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            Vector2 normal = collision.contacts[0].normal;
            ball.AddForce(-normal * bounceStrength);
        }
    }
}
