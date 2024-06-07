using System;
using UnityEngine;

public class GatherStone : MonoBehaviour
{
    public Action onClick;
    public int gatherAmount = 1;
    
    public void OnClick()
    {
        onClick?.Invoke();
        GameData.GameResources.Stone += GameData.Upgrades.GatherStoneMultiplier * gatherAmount;
    }
}
