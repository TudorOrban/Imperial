using System.Collections.Generic;


[System.Serializable]
public class BuildingsData
{
    public List<BuildingData> buildings;
}

[System.Serializable]
public class BuildingData
{
    public string type;
    public List<Farm> farmLevels;
}