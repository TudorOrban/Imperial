using UnityEngine;

public class GameMainMenuController : MonoBehaviour
{
    public GameObject menuPanel;

    private void Start()
    {
        menuPanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape key pressed.");
            ToggleMenu();
        }
    }

    public void ToggleMenu()
    {
        menuPanel.SetActive(!menuPanel.activeSelf);
        if (menuPanel.activeSelf)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void ResumeGame()
    {
        Debug.Log("Resume the game.");
        ToggleMenu();
    }

    public void SaveGame()
    {
        Debug.Log("Save the game here.");
    }

    public void LoadGame()
    {
        Debug.Log("Load the game here");
    }

    public void ExitGame()
    {
        Debug.Log("Exit the game.");
    }

    public void ExitToDesktop()
    {
        Debug.Log("Exit to desktop here");
        Application.Quit();
    }
}