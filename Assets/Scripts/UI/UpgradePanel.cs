using TMPro;
using UnityEngine;

public class UpgradePanel : MonoBehaviour
{
    public TextMeshProUGUI woodLevel;
    public TextMeshProUGUI stoneLevel;
    public TextMeshProUGUI priceLevel;
    public TextMeshProUGUI woodPrice;
    public TextMeshProUGUI stonePrice;
    public TextMeshProUGUI negotiatePricePrice;
    private int baseUpgradePrice = 10;
    
    void Update()
    {
        SetupPanel();
    }

    public void SetupPanel()
    {
        woodLevel.text = GameData.Upgrades.GatherWoodMultiplier.ToString();
        stoneLevel.text = GameData.Upgrades.GatherStoneMultiplier.ToString();
        priceLevel.text = GameData.Upgrades.Price.ToString();
        woodPrice.text = (GameData.Upgrades.GatherWoodMultiplier * baseUpgradePrice).ToString();
        stonePrice.text = (GameData.Upgrades.GatherStoneMultiplier * baseUpgradePrice).ToString();
        negotiatePricePrice.text = (GameData.Upgrades.Price * baseUpgradePrice).ToString();
    }
}
