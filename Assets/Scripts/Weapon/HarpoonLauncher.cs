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
        if (_harpoon!=null)
        {
            if (_harpoon.gameObject.activeSelf)
            {
                return;
            }
        }
        PoolManager.Release(_projectileID, muzzle.position, quaternion.identity).TryGetComponent(out _harpoon);
        _harpoon.Init(transform.up,5);
        _harpoon.ReadyHarpoon(this);
    }
    
    private void Update()
    {
        if (_harpoon!=null)
        {
            return;
        }
        AlignCursor();
    }

    private void AlignCursor()
    {
        var dir=_gear.gearManager._inputManager.mousePosWorld - (Vector2)transform.position;
        dir.Normalize();
        transform.up = dir;
    }
    
}