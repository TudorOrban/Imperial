using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ProvinceDrawer provinceDrawer;
    public Province provincePrefab;
    public DataManager dataManager;

    private void Start()
    {
        GameData gameData = dataManager.LoadGameData();

        List<Province> provinces = new List<Province>();
        foreach (ProvinceData provinceData in gameData.provinces)
        {
            Province province = Instantiate(provincePrefab, Vector3.zero, Quaternion.identity);
            province.name = provinceData.name;
            province.boundaryRegions = provinceData.boundaryRegions;
            provinces.Add(province);
        }

        foreach (Province province in provinces)
        {
            provinceDrawer.DrawBoundary(province);
        }   
    }

}