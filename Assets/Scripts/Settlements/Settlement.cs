using System.Collections.Generic;
using UnityEngine;

public class Settlement
{
    public string name;

    public Vector3 position;
    public Province province;
    public int population;
    public List<Building> buildings;

    public float happiness;
    public float food;
}