using System;
using UnityEngine;

public class InputManager:MonoBehaviour
{
    [SerializeField] private PlayerAction _playerAction;
    [SerializeField] private InputEventChannel _inputEventChannel;
    private float _rotateInput;
    private void OnEnable()
    {
        if (_playerAction == null)
        {
            _playerAction = new PlayerAction();
            _playerAction.MovementInput.Throttle.started +=i=> _inputEventChannel.OnThrottleInput(i.ReadValue<float>());
            _playerAction.MovementInput.Rudder.performed += i => _rotateInput=i.ReadValue<float>();
            _playerAction.MovementInput.Rudder.canceled += i => _rotateInput=i.ReadValue<float>();
        }
        _playerAction.Enable();
    }


    private void Update()
    {
        HandleRotateInput();
    }

    private void HandleRotateInput()
    {
        _inputEventChannel.OnRotateInput(_rotateInput);
    }
}