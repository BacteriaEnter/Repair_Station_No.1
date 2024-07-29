using UnityEngine;

public class WeaponGear:Gear
{
    [SerializeField] private Weapon _weapon;

    public void CancelWeapon()
    {
        
    }

    public override void Engage(Vector2 worldPosition)
    {
        _weapon.Engage(worldPosition);
    }
}