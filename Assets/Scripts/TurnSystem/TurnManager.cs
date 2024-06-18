using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    public int currentTurn { get; private set; } = 1;
    public TextMeshProUGUI turnText;

    private void Start()
    {
        UpdateTurnText(); // Update text on game start
    }

    public void NextTurn()
    {
        currentTurn++;
        Debug.Log("Turn " + currentTurn);
        UpdateTurnText();
    }

    private void UpdateTurnText()
    {
        if (turnText != null)
            turnText.text = currentTurn.ToString(); // Update the text to show the current turn
        else
            Debug.LogError("Turn text not set on TurnManager.");
    }
}