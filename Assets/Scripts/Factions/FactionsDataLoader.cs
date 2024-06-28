using System.IO;
using UnityEngine;

public class FactionsDataLoader : MonoBehaviour
{
    public TextAsset factionsJson;
    public FactionsData LoadedFactionsData { get; private set; }

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

        LoadedFactionsData = JsonUtility.FromJson<FactionsData>(factionsJson.text);
        if (LoadedFactionsData == null || LoadedFactionsData.factions == null)
        {
            Debug.LogError("Failed to load faction data or faction data is null.");
            return;
        }
    }
}

