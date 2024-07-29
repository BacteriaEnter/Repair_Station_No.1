using UnityEngine;

public abstract class Gear:MonoBehaviour
{
    public GearManager gearManager;
    public string gearID;
    public abstract void Engage(Vector2 worldPosition);
    
}