using System;
using UnityEngine;

public class Harpoon:Projectile
{
    private HarpoonLauncher _harpoonLauncher;
    private bool _isCatched;
    private Transform target;
    private Vector3 _offset;
    [SerializeField] private LineRenderer _line;
    [SerializeField] private Transform _lineConnectPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (_isCatched)
        {
            return;
        }
        _offset=other.ClosestPointOnBounds(transform.position);
        transform.position = other.transform.position + _offset;
        _isCatched = true;
        _moveState = ProjectileMoveState.Freeze;
    }

    public void HitCheck()
    {
        if (target==null)
        {
            Death();
        }
    }


    protected override void Update()
    {
        base.Update();
        HandleWire();
    }

    private void HandleWire()
    {
        _line.SetPosition(0,_harpoonLauncher.muzzle.position);
        _line.SetPosition(1,_lineConnectPoint.position);
    }

    public void ReadyHarpoon(HarpoonLauncher hl)
    {
        _harpoonLauncher = hl;
        _isCatched = false;
    }
}