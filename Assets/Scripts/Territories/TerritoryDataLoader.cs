using UnityEngine;
using Newtonsoft.Json;

public class TerritoryDataLoader : MonoBehaviour
{
    public TextAsset gameFlatDataJson;
    public TextAsset gameDataJson;

    public GameData LoadGameFlatData()
    {
        return JsonConvert.DeserializeObject<GameData>(gameFlatDataJson.text);
    }

    public GameData LoadGameData()
    {
        return JsonConvert.DeserializeObject<GameData>(gameDataJson.text);
    }
}