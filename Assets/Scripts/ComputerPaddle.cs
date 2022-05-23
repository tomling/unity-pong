using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D Ball;
    private void FixedUpdate()
    {
        if (Ball.velocity.x > 0.0f)
        {
            if (Ball.position.y > transform.position.y)
            {
                MoveUp();
            }
            else if (Ball.position.y < transform.position.y)
            {
                MoveDown();
            }
        }
        else
        {
            if (transform.position.y > 0.0f)
            {
                MoveDown();
            }
            else if (transform.position.y < 0.0f)
            {
                MoveUp();
            }

        }
    }

    private void MoveDown()
    {
        Rigidbody.AddForce(Vector2.down * Speed);
    }

    private void MoveUp()
    {
        Rigidbody.AddForce(Vector2.up * Speed);
    }
}
