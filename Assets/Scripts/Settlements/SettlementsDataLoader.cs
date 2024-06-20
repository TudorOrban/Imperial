using UnityEngine;
using Newtonsoft.Json;

public class SettlementsDataLoader : MonoBehaviour
{
    public TextAsset gameFlatDataJson;
    public TextAsset gameDataJson;

    public SettlementGameData LoadGameFlatData()
    {
        return JsonConvert.DeserializeObject<SettlementGameData>(gameFlatDataJson.text);
    }

    public SettlementGameData LoadGameData()
    {
        return JsonConvert.DeserializeObject<SettlementGameData>(gameDataJson.text);
    }
}