using System;
using UnityEngine;

public class GatherWood : MonoBehaviour
{
    public Action onClick;
    public int gatherAmount = 1;
    
    public void OnClick()
    {
        onClick?.Invoke();
        GameData.GameResources.Wood += GameData.Upgrades.GatherWoodMultiplier * gatherAmount;
    }
}
