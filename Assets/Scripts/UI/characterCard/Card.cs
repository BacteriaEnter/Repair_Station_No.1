using UnityEngine;

public class Card : MonoBehaviour
{
    [field: SerializeField] public RectTransform RectTransform { get; private set; }
    
    private void Reset()
    {
        RectTransform = GetComponent<RectTransform>();
    }
}
