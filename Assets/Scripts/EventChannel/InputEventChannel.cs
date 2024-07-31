using System;
using UnityEngine;
[CreateAssetMenu(menuName = "EventChannel/InputChannel",fileName = "InputChannelSO")]
public class InputEventChannel:ScriptableObject
{
    public event Action<float> onThrottleInput;
    public event Action<float> onRotateInput;

    public void OnThrottleInput(float throttle)
    {
        //Debug.Log("input throttle:"+ throttle);
        onThrottleInput?.Invoke(throttle);
    }

    public void OnRotateInput(float rotateInput)
    {
        //Debug.Log("input rotate:" + rotateInput);
        onRotateInput?.Invoke(rotateInput);
    }
}