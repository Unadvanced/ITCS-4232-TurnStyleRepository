using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeToBlack : MonoBehaviour
{
    public RawImage rawImage;
    public GameObject finishText;
    public GameObject playAgainButton;
    public GameObject quitButton;
    public GameObject sceneChange;
    public Camera defaultCamera;

    public float fadeDuration = 2.0f;

    private void Start()
    {
        if(rawImage != null)
        {
            Color initialColor = rawImage.color;
            initialColor.a = 0;
            rawImage.color = initialColor;

            StartCoroutine(FadeInAlpha());
        }
    }

    private IEnumerator FadeInAlpha()
    {
        float elapsedTime = 0f;
        Color color = rawImage.color;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float newAlpha = Mathf.Clamp01(elapsedTime / fadeDuration);
            color.a = newAlpha;
            rawImage.color = color;

            yield return null;
        }

        color.a = 1f;
        rawImage.color = color;

        yield return new WaitForSeconds(1);
        finishText.SetActive(true);
        yield return new WaitForSeconds(2);
        AudioListener.volume = 0;

        yield return new WaitForSeconds(28);
        SceneManager.LoadScene(5);

        // playAgainButton.SetActive(true);
        // quitButton.SetActive(true);


    }
}
