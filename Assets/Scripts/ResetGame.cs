using UnityEngine;

public class ResetGame : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            ball.ResetPosition();
        }
    }
}
