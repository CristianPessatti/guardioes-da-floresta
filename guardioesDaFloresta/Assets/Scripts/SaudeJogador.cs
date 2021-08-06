using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaudeJogador : MonoBehaviour
{
    public int saude = 1;
    public int numCoracoes = 1;

    public Image[] coracoes;
    public Sprite coracaoCheio;
    public Sprite coracaoVazio;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(saude > numCoracoes)
        {
            saude = numCoracoes;
        }

        for(int i = 0; i < coracoes.Length; i++)
        {
            if(i < saude)
            {
                coracoes[i].sprite = coracaoCheio;
            }else
            {
                coracoes[i].sprite = coracaoVazio;
            }

            if(i < numCoracoes)
            {
                coracoes[i].enabled = true;
            }else
            {
                coracoes[i].enabled = false;
            }
        }

        if (saude < 1)
        {
            Object.Destroy(gameObject);
            if (gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    public void dano(int dano)
    {
        saude -= dano;
    }

    public void recuperar(int recuperacao)
    {
        saude += recuperacao;
    }
}
