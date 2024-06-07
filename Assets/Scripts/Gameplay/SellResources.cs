using System;
using UnityEngine;

public class SellResources : MonoBehaviour
{
    public Action onClick;
    private int woodAmount = 10;
    private int stoneAmount = 10;

    public void OnClick()
    {
        onClick?.Invoke();
        SellAndChangeResourcesAmount();
    }

    private void SellAndChangeResourcesAmount()
    {
        if (GameData.GameResources.Wood >= 10 && GameData.GameResources.Stone >= 10)
        {
            var woodSellable = GameData.GameResources.Wood / woodAmount;
            var stoneSellable = GameData.GameResources.Stone / stoneAmount;
            var min = Math.Min(woodSellable, stoneSellable);
            GameData.GameResources.Wood -= min * 10;
            GameData.GameResources.Stone -= min * 10;
            GameData.GameResources.Gold += min * GameData.Upgrades.Price;
        }
    }
}
