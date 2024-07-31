using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;

public class CardSlot : MonoBehaviour
{
    [field: SerializeField] public RectTransform RectTransform { get; private set; }
    [field: SerializeField] public List<Card> Cards { get; private set; }
    [SerializeField] float cardWidth = 150;

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

        //调整高度
        var height = cardWidth * (2f - Mathf.Pow(0.5f, Cards.Count - 1) )/ Cards.Count;
        Debug.Log(Cards.Count + "->" + height);
        foreach (var c in Cards)
        {
            c.RectTransform.sizeDelta = new Vector2(cardWidth, height);
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
        
        card.RectTransform.sizeDelta = new Vector2(cardWidth, cardWidth);
        card.RectTransform.SetParent(RectTransform.parent);
        card.RectTransform.SetAsLastSibling();
        
        foreach (var card1 in Cards)
        {
            card1.RectTransform.sizeDelta = new Vector2(cardWidth, cardWidth * (2f - Mathf.Pow(0.5f, Cards.Count - 1)) / Cards.Count);
        }
        return true;
    }
}
