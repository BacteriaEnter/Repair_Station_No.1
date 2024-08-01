using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class AbilityButtonManager : MonoBehaviour
{
    [field: SerializeField] public GearManager GearManager { get; private set; }
    [field: SerializeField] public AbilityButton[] AbilityButtons { get; private set; }

    [Button]
    private void Reset()
    {
        GearManager = FindObjectOfType<GearManager>();
        AbilityButtons = GetComponentsInChildren<AbilityButton>();
    }

    public void Awake()
    {
        foreach (var abilityButton in AbilityButtons)
        {
            abilityButton.Init(this);
        }
    }
}