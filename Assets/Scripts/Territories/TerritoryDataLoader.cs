using UnityEngine;
using Newtonsoft.Json;

public class TerritoryDataLoader : MonoBehaviour
{
    public TextAsset gameFlatDataJson;
    public TextAsset gameDataJson;

    public ProvinceGameData LoadGameFlatData()
    {
        return JsonConvert.DeserializeObject<ProvinceGameData>(gameFlatDataJson.text);
    }

    public ProvinceGameData LoadGameData()
    {
        return JsonConvert.DeserializeObject<ProvinceGameData>(gameDataJson.text);
    }
}