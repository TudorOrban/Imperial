using System.IO;
using UnityEngine;

public class FactionsDataLoader : MonoBehaviour
{
    public TextAsset factionsJson;

    private void Start()
    {
        LoadFactionsConfig();
    }

    private void LoadFactionsConfig()
    {
        if (factionsJson == null)
        {
            Debug.LogError("Factions JSON file is not attached.");
            return;
        }

        FactionsData factionsData = JsonUtility.FromJson<FactionsData>(factionsJson.text);
        if (factionsData == null || factionsData.factions == null)
        {
            Debug.LogError("Failed to load faction data or faction data is null.");
            return;
        }
    }
}

