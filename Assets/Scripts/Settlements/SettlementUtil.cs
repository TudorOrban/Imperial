using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class SettlementUtil : MonoBehaviour
{
    public TextAsset inputJson;
    public Terrain terrain;

    private void Start()
    {
        ConvertSettlements();
    }

    public void ConvertSettlements()
    {
        SettlementGameFlatData gameFlatData = JsonUtility.FromJson<SettlementGameFlatData>(inputJson.text);
        SettlementGameData gameData = new SettlementGameData();
        gameData.settlements = new List<SettlementData>();

        foreach (var settlement in gameFlatData.settlements)
        {
            SettlementData settlement3D = new SettlementData();
            settlement3D.name = settlement.name;
            settlement3D.position = GetTerrainPosition(new Vector3(settlement3D.position.x, 0, settlement3D.position.y));
            
            gameData.settlements.Add(settlement3D);
        }

        string outputPath = Path.Combine(Application.dataPath, "Data", "settlements_3d.json");
        File.WriteAllText(outputPath, JsonUtility.ToJson(gameData, true));
        Debug.Log("Converted settlement data saved to " + outputPath);
    }

    private Vector3 GetTerrainPosition(Vector3 point)
    {
        float height = terrain.SampleHeight(point) + 1f;
        return new Vector3(point.x, height, point.z);
    }
}
