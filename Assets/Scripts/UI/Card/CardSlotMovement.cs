using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardSlotMovement : MonoBehaviour, IPointerDownHandler, IPointerMoveHandler, IPointerUpHandler
{
    private enum MovementType
    {
        Click,
        Drag
    }

    [SerializeField] private MovementType slotMovementType;
    public List<CardSlot> cardSlots;

    private CardSlot _sourceCardSlot;
    private Card _currentCard;

    public void OnPointerDown(PointerEventData eventData)
    {
        var downCardSlot = cardSlots
            .Where(slot =>
                RectTransformUtility.RectangleContainsScreenPoint(slot.RectTransform, eventData.position))
            .FirstOrDefault(slot => slot != null);
        
        if (downCardSlot == null)
            return;

        if (slotMovementType is MovementType.Click)
        {
            if (_sourceCardSlot == null)
            {
                if (downCardSlot.TryRemoveCard(out _currentCard))
                    _sourceCardSlot = downCardSlot;
            }
            else
            {
                downCardSlot.AddCard(_currentCard);
                _sourceCardSlot = null;
                _currentCard = null;
            }
        }
        else
        {
            if (downCardSlot.TryRemoveCard(out _currentCard))
                _sourceCardSlot = downCardSlot;
        }
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        if (_sourceCardSlot == null)
            return;
        
        _currentCard.RectTransform.position = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (_sourceCardSlot == null)
            return;

        if (slotMovementType is not MovementType.Drag)
            return;
        
        var upCardSlot = cardSlots
            .Where(slot =>
                RectTransformUtility.RectangleContainsScreenPoint(slot.RectTransform, eventData.position))
            .FirstOrDefault(slot => slot != null);

        if (upCardSlot == null)
        {
            _sourceCardSlot.AddCard(_currentCard);
        }
        else
        {
            upCardSlot.AddCard(_currentCard);
        }
        
        _sourceCardSlot = null;
        _currentCard = null;
    }
}
