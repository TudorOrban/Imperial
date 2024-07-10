using System.IO;
using UnityEngine;

public class LoadingManager : MonoBehaviour
{
    public LoadingScreenManager loadingScreenManager;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void LoadGame(string filePath)
    {
        Save save = LoadSave(filePath);
        if (save == null)
        {
            Debug.LogError("Failed to load save file: " + filePath);
            return;
        }


        Debug.Log("Loaded save file: " + save.saveAuthor);

    }

    public Save LoadSave(string filePath)
    {
        if (File.Exists(filePath))
        {
            string jsonData = File.ReadAllText(filePath);
            Save save = JsonUtility.FromJson<Save>(jsonData);
            return save;
        }
        else
        {
            Debug.LogError("Save file not found in " + filePath);
            return null;
        }
    }
}