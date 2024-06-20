using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SettlementFlatData
{
    public string name;
    public Vector2 position;
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
    public SettlementModel model;
}

[System.Serializable]
public class SettlementGameData
{
    public List<SettlementData> settlements;
}