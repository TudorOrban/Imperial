using UnityEngine;

public class DataManager : MonoBehaviour
{
    public TextAsset gameDataJson;

    public GameData LoadGameData()
    {
        return JsonUtility.FromJson<GameData>(gameDataJson.text);
    }
}