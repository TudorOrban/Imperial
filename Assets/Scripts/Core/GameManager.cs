using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ProvinceDrawer provinceDrawer;
    public Province provincePrefab;

    private void Start()
    {
        List<Province> provinces = new List<Province>();
        Province province1 = Instantiate(provincePrefab, Vector2.zero, Quaternion.identity);
        province1.name = "Province 1";
        province1.boundaryPoints = new List<Vector2>
        {
            new Vector2(-500, 200),
            new Vector2(-560, 200),
            new Vector2(-560, 160),
            new Vector2(-500, 160)
        };
        provinces.Add(province1);

        foreach (Province province in provinces)
        {
            provinceDrawer.DrawBoundary(province);
        }
    }
}