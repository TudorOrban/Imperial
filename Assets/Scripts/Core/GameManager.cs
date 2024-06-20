using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ProvinceDrawer provinceDrawer;
    public Province provincePrefab;
    public TerritoryDataLoader territoryDataLoader;
    public TerritoryUtil territoryUtil;
    public SettlementsDataLoader settlementsDataLoader;
    public SettlementUtil settlementUtil;
    public SettlementDrawer settlementDrawer;

    private void Start()
    {
        // Provinces
        territoryUtil.ConvertProvinces();

        ProvinceGameData gameData = territoryDataLoader.LoadGameData();

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

        // Settlements
        settlementUtil.ConvertSettlements();

        SettlementGameData settlementGameData = settlementsDataLoader.LoadGameData();

        settlementDrawer.DrawSettlements(settlementGameData);
    }

}