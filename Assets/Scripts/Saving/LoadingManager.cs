using System.IO;
using UnityEngine;

public class LoadingManager : MonoBehaviour
{
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