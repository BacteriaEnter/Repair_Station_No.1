using UnityEngine;

public class MineLauncher:Weapon
{
    [SerializeField] private string _mineId;
    [SerializeField] private Transform _muzzle;
    public override void Engage(Vector3 mousePosWorld)
    {
        Mine mine;
        PoolManager.Release(_mineId, _muzzle.position, Quaternion.identity).TryGetComponent(out mine);
        mine.Init(transform.up,5);
    }
    
    
}