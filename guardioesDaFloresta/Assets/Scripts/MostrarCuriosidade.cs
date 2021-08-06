using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarCuriosidade : MonoBehaviour
{

    public GameObject CanvasPausado;
    public bool rodou = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        Pausar();
    }

    public void Continuar()
    {
        CanvasPausado.SetActive(false);
        Time.timeScale = 1f;

    }

    public void Pausar()
    {
        if (!rodou)
        {
            CanvasPausado.SetActive(true);
            Time.timeScale = 0f;
            rodou = true;
        }
    }
}
