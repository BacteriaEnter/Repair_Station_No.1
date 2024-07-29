using System;
using System.Collections.Generic;
using UnityEngine;

public class GearManager:MonoBehaviour
{
    public InputManager _inputManager;
    [SerializeField] private InputEventChannel _inputEventChannel;
    [SerializeField] private List<GearSlot> _gearSlots = new List<GearSlot>();
    [SerializeField] private Gear _currentSelectedGear;
    
    
    private void OnEnable()
    {
        _inputEventChannel.onModularInput += EnableModularByInputID;
        _inputEventChannel.onConfirmInput += HandleSelectedGear;
    }

    private void OnDisable()
    {
        _inputEventChannel.onModularInput -= EnableModularByInputID;
        _inputEventChannel.onConfirmInput -= HandleSelectedGear;
    }
    
    private void EnableModularByInputID(int i)
    {
        if (_gearSlots[i].currentGear!=null)
        {
            _currentSelectedGear = _gearSlots[i].currentGear;
            //Change cursor
        }
    }
    
    private void HandleSelectedGear(bool confirm)
    {
        if (_currentSelectedGear == null)
        {
            return;
        }
        if (confirm)
        {
            EngageGear(_currentSelectedGear);
        }
        else
        {
            CancelGear();
        }
    }
    

    private void EngageGear(Gear gear)
    {
      gear.Engage(_inputManager.mousePosWorld);
    }

    private void CancelGear()
    {
        _currentSelectedGear = null;
    }


}
