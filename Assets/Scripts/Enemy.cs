using UnityEngine;

public class Enemy:MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;

    public void Pull(Vector3 position)
    {
        transform.position = position;
    }
}