using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public void SaveGame(SaveData data, string saveName)
    {
        string path = Path.Combine(Application.persistentDataPath, "saves");
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        Save save = new Save();
        save.saveAuthor = "Player";
        save.createdAt = DateTime.UtcNow;
        save.updatedAt = DateTime.UtcNow;

        string json = JsonUtility.ToJson(save, true);
        string formattedName = string.Format("{0}${1}.json", saveName, DateTime.UtcNow.ToFileTimeUtc());
        string filePath = Path.Combine(path, formattedName);
        File.WriteAllText(filePath, json);
    }

    public List<string> GetSaveFiles()
    {
        Debug.Log(Application.persistentDataPath);
        string path = Path.Combine(Application.persistentDataPath, "saves");
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            return new List<string>();
        }

        string[] files = Directory.GetFiles(path, "*.json");
        return new List<string>(files);
    }
}
