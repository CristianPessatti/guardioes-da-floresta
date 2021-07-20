using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public static bool estaPausado;

    public GameObject CanvasPausado;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(estaPausado)
            {
                Continuar();
            }else
            {
                Pausar();
            }
        }
    }

    public void Continuar()
    {
        CanvasPausado.SetActive(false);
        Time.timeScale = 1f;
        estaPausado = false;

    }

    public void Pausar()
    {
        CanvasPausado.SetActive(true);
        Time.timeScale = 0f;
        estaPausado = true;
    }

    public void CarregarMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Sair()
    {
        Application.Quit();
    }
}
