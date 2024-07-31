using UnityEngine;

public class GearSlot : MonoBehaviour
{
    [SerializeField] private GearManager _gearManager;
    public Gear currentGear;
    public void SetGear(Gear gear)
    {
        currentGear = gear;
    }

    public void RemoveGear()
    {
        currentGear = null;
    }
}