using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pe : MonoBehaviour
{

    public GameObject jogador;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Plataforma"))
        {
            jogador.transform.parent = other.gameObject.transform;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {

        jogador.transform.parent = null;
    }
}
