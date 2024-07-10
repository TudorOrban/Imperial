using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreenManager : MonoBehaviour
{
    public Image displayImage;
    public Sprite[] imagesToDisplay;
    public TextMeshProUGUI displayText;
    public string[] textsToDisplay;
    public Slider progressBar;

    private int currentImageIndex = 0;
    private int currentTextIndex = 0;

    public void InitializeLoadingScreen(Save save)
    {
        StartCoroutine(ChangeImage());
        StartCoroutine(ChangeText());
        StartCoroutine(LoadGameAsync(save));
    }

    private IEnumerator ChangeImage()
    {
        while (true)
        {
            displayImage.sprite = imagesToDisplay[currentImageIndex];
            currentImageIndex = (currentImageIndex + 1) % imagesToDisplay.Length;
            yield return new WaitForSeconds(10f);
        }
    }

    private IEnumerator ChangeText()
    {
        while (true)
        {
            displayText.text = textsToDisplay[currentTextIndex];
            currentTextIndex = (currentTextIndex + 1) % textsToDisplay.Length;
            yield return new WaitForSeconds(20f);
        }
    }

    private IEnumerator LoadGameAsync(Save save)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("MainScene");

        while (!asyncLoad.isDone)
        {
            progressBar.value = asyncLoad.progress;
            yield return null;
        }
    }
}