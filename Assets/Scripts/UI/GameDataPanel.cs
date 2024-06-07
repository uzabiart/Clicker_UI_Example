using TMPro;
using UnityEngine;

public class GameDataPanel : MonoBehaviour
{
    public TextMeshProUGUI woodAmount;
    public TextMeshProUGUI stoneAmount;
    public TextMeshProUGUI goldAmount;
    
    private void Update()
    {
        SetupPanel();
    }

    private void SetupPanel()
    {
        woodAmount.text = GameData.GameResources.Wood.ToString();
        stoneAmount.text = GameData.GameResources.Stone.ToString();
        goldAmount.text = GameData.GameResources.Gold.ToString();
    }
}
