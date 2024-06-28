using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadGameUIManager : MonoBehaviour
{
    public SaveManager saveManager;
    public GameObject saveButtonTemplate;
    public Transform savesButtonContainer;

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
            tmpText.text = Path.GetFileName(saveFile);
        }
    }

}