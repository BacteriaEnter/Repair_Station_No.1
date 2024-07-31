using System;
using UnityEngine;

public class Projectile:MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _damage;
    [SerializeField] private LifeTimer _lifeTimer;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] protected ProjectileMoveState _moveState;
    
    public virtual void Init(Vector3 dir,float damage)
    {
        transform.up = dir;
        _lifeTimer.Timer();
    }

    protected virtual void Update()
    {
        if (_moveState==ProjectileMoveState.Move)
        {
            Move();
        }

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

public enum ProjectileMoveState
{
    Move,
    Freeze
}