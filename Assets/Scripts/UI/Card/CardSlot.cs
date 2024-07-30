using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;

public class CardSlot : MonoBehaviour
{
    [field: SerializeField] public RectTransform RectTransform { get; private set; }
    [field: SerializeField] public List<Card> Cards { get; private set; }

    [Button]
    private void Reset()
    {
        RectTransform = GetComponent<RectTransform>();
        Cards = GetComponentsInChildren<Card>().ToList();
    }

    public void AddCard(Card card)
    {
        Cards.Add(card);
        
        card.RectTransform.SetParent(RectTransform);
        card.RectTransform.SetAsFirstSibling();

        //todo 需要手写一个排列，不用自带的垂直布局组件
        var height = 1f / Cards.Count * 100 + (Cards.Count - 1) * 5;
        
        foreach (var c in Cards)
        {
            c.RectTransform.sizeDelta = new Vector2(100, height);
        }
    }

    public bool TryRemoveCard(out Card card)
    {
        if (Cards.Count <= 0)
        {
            card = null;
            return false;
        }
        
        card = Cards[^1];
        Cards.RemoveAt(Cards.Count - 1);
        
        card.RectTransform.sizeDelta = new Vector2(100, 100);
        card.RectTransform.SetParent(RectTransform.parent);
        card.RectTransform.SetAsLastSibling();
        
        foreach (var card1 in Cards)
        {
            card1.RectTransform.sizeDelta = new Vector2(100, 1f / Cards.Count * 100 + (Cards.Count - 1) * 5);
        }
        return true;
    }
}
