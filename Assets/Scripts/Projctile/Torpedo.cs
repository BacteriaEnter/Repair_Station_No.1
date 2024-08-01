using DG.Tweening;
using UnityEngine;

public class Torpedo:Projectile
{
    [SerializeField] private float delayTime;
    public override void Init(Vector3 dir, float damage)
    {
        base.Init(dir, damage);
        _moveState = ProjectileMoveState.Freeze;
        DOVirtual.DelayedCall(delayTime, Delay);
    }
    private void Delay()
    {
        _moveState = ProjectileMoveState.Move;
    }  
}