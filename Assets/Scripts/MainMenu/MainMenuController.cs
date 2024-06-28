using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public GameObject factionSelectionCanvas;
    public GameObject loadGameCanvas;

    private void Start()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        mainMenuCanvas.SetActive(true);
        factionSelectionCanvas.SetActive(false);
        loadGameCanvas.SetActive(false);
    }

    public void ShowFactionSelection()
    {
        mainMenuCanvas.SetActive(false);
        factionSelectionCanvas.SetActive(true);
    }

    public void ShowLoadGameScreen()
    {
        mainMenuCanvas.SetActive(false);
        loadGameCanvas.SetActive(true);
    }
}