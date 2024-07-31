using UnityEngine;

public class ShoutCannon:Weapon
{
    [SerializeField] private string _projectileID;
    [SerializeField] private float _spreadAngle;
    [SerializeField] private int _projectileCount;
    [SerializeField] private Transform _muzzle;
    public override void Engage(Vector3 mousePosWorld)
    {
        float startAngle=_projectileCount*_spreadAngle/2;
        for (int i = 0; i < _projectileCount; i++)
        {
            var dir=Quaternion.Euler(0, 0, startAngle + i * _spreadAngle)*_muzzle.up;
            PoolManager.Release(_projectileID, _muzzle.position, Quaternion.identity).TryGetComponent(out Projectile projectile);
            projectile.Init(dir,5);
        }
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