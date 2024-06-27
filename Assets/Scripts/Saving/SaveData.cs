using System;
using System.Collections.Generic;

public class Save
{
    public string saveAuthor;
    public DateTime createdAt;
    public DateTime updatedAt;
   
}

public class SaveData
{
    public InitialData initialData;
    public int turn;
    public string factionName;
    public string capital;
    public int currentPopulation;
    public int currentTreasury;
}

public class InitialData
{
    public StartingTime startingTime;
}

public class StartingTime
{
    public int year;
    public Season season;
}

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

public class ProvincesSaveData
{
    public List<ProvinceSaveData> provincesData;
}

public class ProvinceSaveData
{
    public string name;
    public string currentPopulation;
    public OccupationDistribution currentDistribution;
    public int currentIncome;
    public int currentExpenses;
    public int currentFood;
    public int currentFoodConsumption;
    public string governor;
}

public class OccupationDistribution
{
    public float farmers;
    public float craftsmen;
    public float merchants;
    public float clerks;
    public float knights;
    public float nobles;
}