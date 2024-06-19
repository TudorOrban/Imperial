using System.IO;
using UnityEngine;

public class BuildingsDataLoader : MonoBehaviour
{
    public TextAsset buildingsJson;

    private void Start()
    {
        LoadBuildingsConfig();
    }

    private void LoadBuildingsConfig()
    {
        if (buildingsJson == null)
        {
            Debug.LogError("Buildings JSON file is not attached.");
            return;
        }

        BuildingsData buildingsData = JsonUtility.FromJson<BuildingsData>(buildingsJson.text);
        if (buildingsData == null || buildingsData.buildings == null)
        {
            Debug.LogError("Failed to load building data or buildings data is null.");
            return;
        }
    }
}

