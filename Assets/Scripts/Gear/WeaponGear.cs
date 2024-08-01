using UnityEngine;

public class WeaponGear:Gear
{
    [SerializeField] private Weapon _weapon;

    public void CancelWeapon()
    {
        
    }

    public override Sprite Sprite => _weapon.Sprite;

    public override void Engage(Vector2 worldPosition)
    {
        _weapon.Engage(worldPosition);
    }
}