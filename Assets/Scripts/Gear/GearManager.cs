using System.Collections.Generic;
using UnityEngine;

public class GearManager:MonoBehaviour
{
    public InputManager _inputManager;
    [SerializeField] private InputEventChannel _inputEventChannel;
    [field: SerializeField] public List<GearSlot> GearSlots { get; private set; }
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
    
    public void EnableModularByInputID(int i)
    {
        if (GearSlots[i].CurrentGear!=null)
        {
            _currentSelectedGear = GearSlots[i].CurrentGear;
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