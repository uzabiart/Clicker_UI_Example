using System;
using UnityEngine;

public class UpgradeLevel : MonoBehaviour
{
    public Action onClick;
    public Upgrade upgradeType;

    public void OnClick()
    {
        BuyUpdate();
    }

    private void BuyUpdate()
    {
        switch (upgradeType)
        {
            case Upgrade.Wood:
            {
                var price = GameData.Upgrades.GatherWoodMultiplier * 10;
                if (price <= GameData.GameResources.Gold)
                {
                    GameData.GameResources.Gold -= price;
                    GameData.Upgrades.GatherWoodMultiplier += 1;
                }
                break;
            }
            case Upgrade.Stone:
            {
                var price = GameData.Upgrades.GatherStoneMultiplier * 10;
                if (price <= GameData.GameResources.Gold)
                {
                    GameData.GameResources.Gold -= price;
                    GameData.Upgrades.GatherStoneMultiplier += 1;
                }
                break;
            }
            case Upgrade.Price:
            {
                var price = GameData.Upgrades.Price * 10;
                if (price <= GameData.GameResources.Gold)
                {
                    GameData.GameResources.Gold -= price;
                    GameData.Upgrades.Price += 1;
                }
                break;
            }
        }
    }
}

public enum Upgrade
{
    Stone,
    Wood,
    Price
}
