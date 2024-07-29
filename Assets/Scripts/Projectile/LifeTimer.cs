using System;
using UnityEngine;
using UnityEngine.Events;

public class LifeTimer:MonoBehaviour
{
    [SerializeField] private float _lifeTime;
    private float _currentTimer;
    [SerializeField] private UnityEvent onLifeTimeEnd;
    private void Update()
    {
        _currentTimer -= Time.deltaTime;
        if (_currentTimer<=0)
        {
            onLifeTimeEnd?.Invoke();
            enabled = false;
        }
    }

    public void Timer()
    {
        _currentTimer = _lifeTime;
        enabled = true;
    }
    
    
}