using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadingTextEffect : MonoBehaviour
{
    public TMP_Text loadingText;
    public float dotInterval = 0.5f; // Intervalo entre os pontos
    public float delayBeforeSceneChange = 3f; // Tempo antes de mudar de cena
    public string sceneToLoad; // Nome da cena para carregar

    private void Start()
    {
        if (loadingText != null)
        {
            StartCoroutine(AnimateLoadingText());
        }
        StartCoroutine(WaitAndLoadScene());
    }

    private IEnumerator AnimateLoadingText()
    {
        string baseText = "Loading";
        int dotCount = 0;

        while (true)
        {
            dotCount = (dotCount + 1) % 4; // Mantém os pontos entre 0 e 3
            loadingText.text = baseText + new string('.', dotCount); // Atualiza o texto com pontos

            yield return new WaitForSeconds(dotInterval); // Espera o intervalo especificado
        }
    }

    private IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(delayBeforeSceneChange); // Espera o tempo especificado

        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad); // Carrega a nova cena
        }
    }
}
