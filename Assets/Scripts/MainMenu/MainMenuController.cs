using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public GameObject factionSelectionCanvas;

    private void Start()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        mainMenuCanvas.SetActive(true);
        factionSelectionCanvas.SetActive(false);
    }

    public void ShowFactionSelection()
    {
        mainMenuCanvas.SetActive(false);
        factionSelectionCanvas.SetActive(true);
    }
}