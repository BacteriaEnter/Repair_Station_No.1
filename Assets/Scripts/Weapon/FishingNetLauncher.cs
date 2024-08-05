using UnityEngine;

public class FishingNetLauncher:Weapon
{
    [SerializeField] private string _projectileID;
    [SerializeField] private Transform _muzzle;
    [SerializeField] private string _fxID;
    public override void Engage(Vector3 mousePosWorld)
    {
        var go=PoolManager.Release(_fxID, _muzzle.transform.position, Quaternion.identity);
        go.transform.up = _muzzle.up;
        Projectile projectile;
        PoolManager.Release(_projectileID, _muzzle.transform.position, Quaternion.identity).TryGetComponent(out projectile);
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