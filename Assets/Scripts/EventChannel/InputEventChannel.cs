using System;
using UnityEngine;
[CreateAssetMenu(menuName = "EventChannel/InputChannel",fileName = "InputChannelSO")]
public class InputEventChannel:ScriptableObject
{
    public event Action<float> onThrottleInput;
    public event Action<float> onRotateInput;
    public event Action<int> onModularInput;
    public event Action<bool> onConfirmInput;

    public void OnThrottleInput(float throttle)
    {
        onThrottleInput?.Invoke(throttle);
    }

    public void OnRotateInput(float rotateInput)
    {
        onRotateInput?.Invoke(rotateInput);
    }

    public void OnModularInput(int obj)
    {
        onModularInput?.Invoke(obj);
    }

    public void OnConfirmInput(bool confirm)
    {
        onConfirmInput?.Invoke(confirm);
    }
}