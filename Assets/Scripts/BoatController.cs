using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class BoatController : MonoBehaviour
{
    [SerializeField] private InputManager _inputManager;
    [SerializeField] private InputEventChannel _inputEventChannel;
    [SerializeField] private float _forwardSpeedPerGear;
    [SerializeField] private float _reverseSpeedPerGear;
    
    [SerializeField] private int _maxForwardGear;
    [SerializeField] private int _maxReverseGear;
    

    [SerializeField] private int _currentGear;
    [SerializeField] private float _acceleration;
    [SerializeField] private float _currentMaxSpeed;
    [SerializeField] private float _currentSpeed;
    [SerializeField] private float _currentRudder;
    [SerializeField] private float _inputPerRudder;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _rudderRotateSpeed;
    private Quaternion _targetRotation;
    [SerializeField] private Rigidbody2D _rb;
    private BoostDirection _boostDirection;
    private bool _isTurning;
    
    private void OnEnable()
    {
        _inputEventChannel.onThrottleInput += Throttle;
        _inputEventChannel.onRotateInput += Rotate;
    }

    private void Throttle(float throttle)
    {
        _currentGear+= (int)throttle;
        if (throttle>0)
        {
            _currentGear =Mathf.Min(_currentGear, _maxForwardGear);
            _boostDirection = BoostDirection.Forward;
        }
        else if (throttle<0)
        {
            _currentGear =Mathf.Max(_currentGear , _maxReverseGear);
            _boostDirection = BoostDirection.Reverse;
        }
        else
        {
            _boostDirection = BoostDirection.Idle;
        }

        _currentMaxSpeed = _currentGear >= 0 ? _currentGear * _forwardSpeedPerGear : _currentGear * _reverseSpeedPerGear;
        
    }

    private void Rotate(float rotateInput)
    {
        if (_currentSpeed == 0)
        {
            return;
        }
        _currentRudder += rotateInput*_inputPerRudder*Time.deltaTime;
        _currentRudder = Mathf.Clamp(_currentRudder,-1, 1);
        if (rotateInput is >= -0.1f and <= 0.1f)
        {
            _isTurning = false;
        }
        else
        {
            _isTurning = true;
        }
    }

    private void ResetRudder()
    {
        if (Mathf.Abs(_currentSpeed)!=0&&!_isTurning)
        {
            // float a=_currentSpeed / _currentSpeed;
            _currentRudder = Mathf.Lerp(_currentRudder, 0,0.05f*Time.deltaTime);
            if (_currentRudder<=0.05f&&_currentRudder>=-0.05f)
            {
                _currentRudder = 0;
            }
        }
    }

    private void Update()
    {
        HandleRotation();
        HandleMovement();
        ResetRudder();
    }
    

    private void HandleMovement()
    {
        _currentSpeed += _acceleration*(int)_boostDirection*Time.deltaTime;
        if (_boostDirection == BoostDirection.Forward)
        {
            _currentSpeed = MathF.Min(_currentSpeed, _currentMaxSpeed);
        }
        else
        {
            _currentSpeed = MathF.Max(_currentSpeed, _currentMaxSpeed);
        }
     
        _rb.velocity = transform.up * _currentSpeed;
    }

    private void HandleRotation()
    {
        var faceDir=transform.up + transform.right * _currentRudder;
        faceDir.z = 0;
        faceDir.Normalize();
        var up = transform.up;
        var rotationAxis = Vector3.Cross(up, faceDir);
        var angle = Vector3.Angle(up, faceDir);
        _targetRotation = Quaternion.AngleAxis(angle, rotationAxis)*transform.rotation;
        transform.rotation=Quaternion.Slerp(transform.rotation, _targetRotation, Time.deltaTime*_rotateSpeed);
    }
}

public enum BoostDirection
{
    Reverse=-1,
    Idle,
    Forward
}