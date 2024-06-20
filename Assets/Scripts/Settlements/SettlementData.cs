using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SettlementFlatData
{
    public string name;
    public Vector2 position;
    public string provinceName;
    public Province province;
    public string model;

    public List<Building> buildings;

    public int population;
    public float happiness;
    public float food;
}

[System.Serializable]
public class SettlementGameFlatData
{
    public List<SettlementFlatData> settlements;
}

[System.Serializable]
public class SettlementData
{
    public string name;
    public Vector3 position;
    public string provinceName;
    public Province province;
    public string model;

    public List<Building> buildings;

    public int population;
    public float happiness;
    public float food;
}

[System.Serializable]
public class SettlementGameData
{
    public List<SettlementData> settlements;
}