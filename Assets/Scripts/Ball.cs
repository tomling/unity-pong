using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    public float Speed = 200.0f;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        AddStartingForce();
    }

    private void AddStartingForce()
    {
        var x = Random.value < 0.5f ? -1.0f : 1.0f;
        var y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1f);

        var direction = new Vector2(x, y);

        _rigidbody.AddForce(direction * Speed);
    }

}
