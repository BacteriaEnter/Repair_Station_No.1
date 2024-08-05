﻿using System;
using UnityEngine;
using UnityEngine.Serialization;

public class SmallCannonBall:Projectile
{
    [SerializeField] private LayerMask _checkLayer;
    [SerializeField] private float _explodeRiadus;
    [SerializeField] private int damage;

    public override void Init(Vector3 dir, float damage)
    {
        base.Init(dir, damage);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Explode();
    }

    public void Explode()
    {
      
        PoolManager.Release(_fxID, transform.position, Quaternion.identity);
        var colliders=Physics2D.CircleCastAll(transform.position, _explodeRiadus, Vector2.zero, 0, _checkLayer);
        if (colliders.Length <= 0) return;
        Enemy enemy=null;
        foreach (var collider in colliders)
        {
            if (collider.collider.TryGetComponent(out enemy))
            {
                enemy.TakeDamage(damage);
            }
        }
        Death();
    }
}