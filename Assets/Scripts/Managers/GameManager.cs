using System;
using UnityEngine;

public class GameManager:MonoBehaviour
{
    private void Start()
    {
        WholeConfig wholeConfig = new WholeConfig();
        wholeConfig.LoadData();
        ResourceManager.Inst.wholeConfig = wholeConfig;
    }
}