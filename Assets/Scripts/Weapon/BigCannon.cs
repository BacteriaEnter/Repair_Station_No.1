using System;
using Unity.Mathematics;
using UnityEngine;

public class BigCannon:Weapon
{
    [SerializeField] private string _projectileID;
    [SerializeField] private Transform _muzzle;
    public override void Engage(Vector3 mousePosWorld)
    {
        Projectile projectile;
        PoolManager.Release(_projectileID, _muzzle.transform.position, quaternion.identity).TryGetComponent(out projectile);
        projectile.Init(transform.up,5);
    }

    private void Update()
    {
        AlignCursor();
    }

    private void AlignCursor()
    {
        var dir=_gear.gearManager._inputManager.mousePosWorld - (Vector2)transform.position;
        dir.Normalize();
        transform.up = dir;
    }
}