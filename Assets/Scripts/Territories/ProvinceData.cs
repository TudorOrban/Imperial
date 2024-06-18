using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ProvinceFlatData
{
    public string name;
    public List<Vector2> boundaryPoints;
}

[System.Serializable]
public class GameFlatData
{
    public List<ProvinceFlatData> provinces;
}

[System.Serializable]
public class ProvinceData
{
    public string name;
    public string capital;
    public List<Vector3> boundaryPoints;
}

[System.Serializable]
public class GameData
{
    public List<ProvinceData> provinces;
}