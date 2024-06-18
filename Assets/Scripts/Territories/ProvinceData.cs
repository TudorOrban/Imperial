using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ProvinceData
{
    public string name;
    public List<List<Vector2>> boundaryRegions;
}

[System.Serializable]
public class GameData
{
    public List<ProvinceData> provinces;
}