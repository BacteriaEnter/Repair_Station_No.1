using System;
using UnityEngine;

public class Projectile:MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _damage;
    [SerializeField] private LifeTimer _lifeTimer;
    [SerializeField] private Rigidbody2D _rb;
    
    public void Init(Vector3 dir,float damage)
    {
        transform.up = dir;
        _lifeTimer.Timer();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _rb.velocity = transform.up * _speed;
    }

    public void Death()
    {
        gameObject.SetActive(false);
    }
}