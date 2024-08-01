using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

public class HarpoonLauncher:Weapon
{
    [SerializeField] private string _projectileID;
    public Transform muzzle;
    private Harpoon _harpoon;
    public override void Engage(Vector3 mousePosWorld)
    {
        _harpoon = null;
        PoolManager.Release(_projectileID, muzzle.position, quaternion.identity).TryGetComponent(out _harpoon);
        _harpoon.Init(transform.up,5);
    }
    
    
    
}