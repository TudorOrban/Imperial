using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ProvinceDrawer provinceDrawer;
    public Province provincePrefab;
    public TerritoryDataLoader dataManager;
    public TerritoryUtil territoryUtil;

    private void Start()
    {
        territoryUtil.ConvertProvinces();

        GameData gameData = dataManager.LoadGameData();

        List<Province> provinces = new List<Province>();
        foreach (ProvinceData provinceData in gameData.provinces)
        {
            Province province = Instantiate(provincePrefab, Vector3.zero, Quaternion.identity);
            province.name = provinceData.name;
            province.boundaryPoints = provinceData.boundaryPoints;
            provinces.Add(province);
        }

        foreach (Province province in provinces)
        {
            provinceDrawer.DrawBoundary(province);
        }   
    }

}