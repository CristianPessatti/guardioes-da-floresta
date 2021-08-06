using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarregarPersonagem : MonoBehaviour
{

    public GameObject[] prefabsPersonagens;
    public Transform localDeInicio;

    void Start()
    {
        int personagemSelecionado = PlayerPrefs.GetInt("personagemEscolhido");
        GameObject prefab = prefabsPersonagens[personagemSelecionado];
        GameObject clone = Instantiate(prefab, localDeInicio.position, Quaternion.identity);
    }
}
