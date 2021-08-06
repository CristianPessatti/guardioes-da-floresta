using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscolherPersonagem : MonoBehaviour
{
    public void escolherRaoni()
    {
        PlayerPrefs.SetInt("personagemEscolhido", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void escolherJanaina()
    {
        PlayerPrefs.SetInt("personagemEscolhido", 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
