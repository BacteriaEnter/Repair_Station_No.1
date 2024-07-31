using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public Gear _gear;
    public abstract void Engage(Vector3 mousePosWorld);
}