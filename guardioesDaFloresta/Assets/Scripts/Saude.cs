using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Saude : MonoBehaviour
{
    public int saude = 1;

    void Start() {
        
    }

    void Update() {
        if(saude < 1) {
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
}
