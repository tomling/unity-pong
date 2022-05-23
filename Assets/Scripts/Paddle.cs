using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float Speed = 10.0f;

    protected Rigidbody2D Rigidbody;

    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }

}