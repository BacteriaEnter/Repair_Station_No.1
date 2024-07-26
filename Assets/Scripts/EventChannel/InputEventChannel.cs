using System;
using UnityEngine;
[CreateAssetMenu(menuName = "EventChannel/InputChannel",fileName = "InputChannelSO")]
public class InputEventChannel:ScriptableObject
{
    public event Action<float> onThrottleInput;
    public event Action<float> onRotateInput;

    public void OnThrottleInput(float throttle)
    {
        onThrottleInput?.Invoke(throttle);
    }

    public void OnRotateInput(float rotateInput)
    {
        onRotateInput?.Invoke(rotateInput);
    }
}