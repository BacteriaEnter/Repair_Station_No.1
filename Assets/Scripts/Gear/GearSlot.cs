using UnityEngine;

public class GearSlot : MonoBehaviour
{
    [SerializeField] private GearManager _gearManager;
    [field: SerializeField] public Gear CurrentGear { get; private set; }
    
    public void SetGear(Gear gear)
    {
        CurrentGear = gear;
    }

    public void RemoveGear()
    {
        CurrentGear = null;
    }
}