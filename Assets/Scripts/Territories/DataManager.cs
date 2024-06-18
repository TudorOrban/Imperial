using UnityEngine;
using Newtonsoft.Json;

public class DataManager : MonoBehaviour
{
    public TextAsset gameDataJson;

    public GameData LoadGameData()
    {
        return JsonConvert.DeserializeObject<GameData>(gameDataJson.text);
    }
}