using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameResources GameResources = new GameResources();
    public static Upgrades Upgrades = new Upgrades();
}

public class GameResources
{
    public int Wood { get; set; }
    public int Stone { get; set; }
    public int Gold { get; set; }
}

public class Upgrades
{
    public int GatherWoodMultiplier { get; set; } = 1;
    public int GatherStoneMultiplier { get; set; } = 1;
    public int Price { get; set; } = 1;
}
