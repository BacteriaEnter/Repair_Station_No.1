using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager:MonoBehaviour
{
    [SerializeField] private PlayerAction _playerAction;
    [SerializeField] private InputEventChannel _inputEventChannel;
    private float _rotateInput;
    public Vector2 mousePosWorld;
    
    private void OnEnable()
    {
        if (_playerAction == null)
        {
            _playerAction = new PlayerAction();
            _playerAction.MovementInput.Throttle.started +=i=> _inputEventChannel.OnThrottleInput(i.ReadValue<float>());
            _playerAction.MovementInput.Rudder.performed += i => _rotateInput=i.ReadValue<float>();
            _playerAction.MovementInput.Rudder.canceled += i => _rotateInput=i.ReadValue<float>();
            _playerAction.MovementInput.Modular1.canceled += i => HandleModularInput(0);
            _playerAction.MovementInput.Modular2.canceled += i => HandleModularInput(1);
            _playerAction.MovementInput.Modular3.canceled += i => HandleModularInput(2);
            _playerAction.MovementInput.Modular4.canceled += i => HandleModularInput(3);
            _playerAction.MovementInput.Modular5.canceled += i => HandleModularInput(4);
            _playerAction.MovementInput.Modular6.canceled += i => HandleModularInput(5);
            _playerAction.ActionInput.Confirm.started += i => HandleConfirmInput(true);
            _playerAction.ActionInput.Cancel.started += i => HandleConfirmInput(false);
        }
        _playerAction.Enable();
    }


    private void Update()
    {
        mousePosWorld=Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        HandleRotateInput();
    }

    private void HandleRotateInput()
    {
        _inputEventChannel.OnRotateInput(_rotateInput);
    }

    private void HandleModularInput(int modularInput)
    {
        _inputEventChannel.OnModularInput(modularInput);
    }

    private void HandleConfirmInput(bool confirm)
    {
        _inputEventChannel.OnConfirmInput(confirm);
    }
}