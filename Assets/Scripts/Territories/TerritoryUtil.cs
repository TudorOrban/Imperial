using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class TerritoryUtil : MonoBehaviour
{
    public TextAsset inputJson;
    public Terrain terrain;

    private void Start()
    {
        ConvertProvinces();
    }

    public void ConvertProvinces()
    {
        ProvinceGameFlatData gameFlatData = JsonUtility.FromJson<ProvinceGameFlatData>(inputJson.text);
        ProvinceGameData gameData = new ProvinceGameData();
        gameData.provinces = new List<ProvinceData>();

        foreach (var province in gameFlatData.provinces)
        {
            ProvinceData province3D = new ProvinceData();
            province3D.name = province.name;
            province3D.boundaryPoints = new List<Vector3>();

            foreach (var point in province.boundaryPoints)
            {
                Vector3 terrainPoint = GetTerrainPosition(new Vector3(point.x, 0, point.y));
                province3D.boundaryPoints.Add(terrainPoint);
            }

            gameData.provinces.Add(province3D);
        }

        string outputPath = Path.Combine(Application.dataPath, "Data", "provinces_3d.json");
        File.WriteAllText(outputPath, JsonUtility.ToJson(gameData, true));
        Debug.Log("Converted data saved to " + outputPath);
    }

    private Vector3 GetTerrainPosition(Vector3 point)
    {
        float height = terrain.SampleHeight(point) + 1f;
        return new Vector3(point.x, height, point.z);
    }
}
