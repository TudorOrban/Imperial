using System.Collections.Generic;
using System.Drawing;

[System.Serializable]
public class Faction
{
    public string name;
    public Color factionColor;
    public string lordName;
    public string heirName;
    public List<string> startingProvinceNames;

    public int startingGold;
    public int startingIncome;
    public int startingFood;
    public float startingReputation;
}