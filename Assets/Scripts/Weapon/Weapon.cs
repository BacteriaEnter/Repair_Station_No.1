using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [field: SerializeField] public Sprite Sprite { get; private set; }
    public Gear _gear;
    public abstract void Engage(Vector3 mousePosWorld);
}