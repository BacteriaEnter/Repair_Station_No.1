using UnityEngine;

public class TorpedoLauncher:Weapon
{
    [SerializeField] private string _mineId;
    [SerializeField] private Transform _muzzle;
    public override void Engage(Vector3 mousePosWorld)
    {
        Torpedo mine;
        PoolManager.Release(_mineId, _muzzle.position, Quaternion.identity).TryGetComponent(out mine);
        mine.Init(transform.up,5);
    }
}