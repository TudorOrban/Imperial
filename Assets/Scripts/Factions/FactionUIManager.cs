using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FactionUIManager : MonoBehaviour
{
    public FactionsDataLoader dataLoader;
    public GameObject factionButtonTemplate;
    public Transform factionButtonContainer;

    public void ShowFactions()
    {
        if (dataLoader.LoadedFactionsData == null || dataLoader.LoadedFactionsData.factions == null)
        {
            Debug.LogError("Faction data is not loaded or is null");
            return;
        }

        foreach (Faction faction in dataLoader.LoadedFactionsData.factions)
        {
            GameObject buttonObj = Instantiate(factionButtonTemplate, factionButtonContainer);
            buttonObj.SetActive(true);

            TextMeshProUGUI buttonText = buttonObj.GetComponentInChildren<TextMeshProUGUI>();
            if (buttonText == null)
            {
                Debug.LogError("TextMeshProUGUI component not found on button template.");
                continue;
            }
            buttonText.text = faction.name;

            Button button = buttonObj.GetComponent<Button>();
            if (button == null)
            {
                Debug.LogError("Button component not found on instantiated object.");
                continue;
            }
            button.onClick.AddListener(() => FactionButtonClicked(faction));
        }
    }

    private void FactionButtonClicked(Faction faction)
    {
        Debug.Log("Selected faction: " + faction.name);
    }
}
