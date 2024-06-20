using System.Collections.Generic;
using UnityEngine;

public class Settlement
{
    public string name;

    public Vector3 position;
    public string provinceName;
    public Province province;
    public SettlementModel model;

    public List<Building> buildings;

    public int population;
    public float happiness;
    public float food;
}