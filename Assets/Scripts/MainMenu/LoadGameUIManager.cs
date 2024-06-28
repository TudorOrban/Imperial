using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadGameUIManager : MonoBehaviour
{
    public LoadingManager loadingManager;
    public SaveManager saveManager;

    public GameObject saveButtonTemplate;
    public Transform savesButtonContainer;

    public string selectedSavePath;

    public void ShowSaves()
    {
        if (saveManager == null)
        {
            Debug.LogError("SaveManager is not assigned in the Inspector");
            return;
        }

        List<string> saveFiles = saveManager.GetSaveFiles();

        if (saveFiles == null || saveFiles.Count == 0)
        {
            Debug.LogError("No save files found.");
            return;
        }

        foreach (string saveFile in saveFiles)
        {
            GameObject buttonObj = Instantiate(saveButtonTemplate, savesButtonContainer);
            buttonObj.SetActive(true);

            TextMeshProUGUI tmpText = buttonObj.GetComponentInChildren<TextMeshProUGUI>();
            if (tmpText == null)
            {
                Debug.LogError("TextMeshProUGUI component not found on button template.");
                continue;
            }

            string displayName = Path.GetFileNameWithoutExtension(saveFile).Split('$')[0];
            tmpText.text = displayName;

            Button button = buttonObj.GetComponent<Button>();
            button.onClick.AddListener(() => SelectSaveFile(saveFile));
        }
    }

    private void SelectSaveFile(string filePath)
    {
        selectedSavePath = filePath;
        Debug.Log("Selected save file: " + selectedSavePath);
    }

    public void LoadFile()
    {
        if (string.IsNullOrEmpty(selectedSavePath))
        {
            Debug.LogError("No save file selected.");
            return;
        }

        loadingManager.LoadGame(selectedSavePath);
    }
}