using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saude : MonoBehaviour
{
    public int saude = 1;

    void Start() {
        
    }

    void Update() {
        if(saude < 1) {
            Object.Destroy(gameObject);
        }
    }

    public void dano(int dano)
    {
        saude -= dano;
    }
}
