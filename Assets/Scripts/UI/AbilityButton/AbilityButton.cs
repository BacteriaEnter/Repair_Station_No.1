using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class AbilityButton : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private int index;
    [SerializeField] private Image image;

    private Gear _currentGear;
    private Gear CurrentGear
    {
        get => _currentGear;
        set
        {
            if (_currentGear == value)
                return;
            _currentGear = value;
            if (_currentGear != null)
                image.sprite = _currentGear.Sprite;
        }
    }
    
    private AbilityButtonManager _abilityButtonManager;

    private void Reset()
    {
        button = GetComponent<Button>();
    }

    public void Init(AbilityButtonManager abilityButtonManager)
    {
        _abilityButtonManager = abilityButtonManager;
        // todo 之后加个模块变化事件，该UI监听事件；或者在AbilityButtonManager中监听事件
        // _abilityButtonManager.GearManager.OnGearChange += i => { };
        CurrentGear = _abilityButtonManager.GearManager.GearSlots[index].CurrentGear;
    }

    private void OnEnable()
    {
        button.onClick.AddListener(() => _abilityButtonManager.GearManager.EnableModularByInputID(index));
    }

    private void OnDisable()
    {
        button.onClick.RemoveAllListeners();
    }
}
