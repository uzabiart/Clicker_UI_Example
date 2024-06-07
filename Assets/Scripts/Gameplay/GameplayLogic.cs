using UnityEngine;

public class GameplayLogic : MonoBehaviour
{

    public CurrentResources GetGameData()
    {
        return new CurrentResources
        {
            Wood = GameData.GameResources.Wood,
            Gold = GameData.GameResources.Gold,
            Stone = GameData.GameResources.Stone
        };
    }
}

public class CurrentResources
{
    public int Wood { get; set; }
    public int Stone { get; set; }
    public int Gold { get; set; }
}
