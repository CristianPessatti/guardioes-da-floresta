using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FazerTransicao : MonoBehaviour {

    public Animator transicao;
    public float tempoTransicao = 1f;

    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            CarregarProximoLevel();
        }
    }

    public void CarregarProximoLevel() {
        StartCoroutine(CarregarLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator CarregarLevel(int index) {
        transicao.SetTrigger("Start");

        yield return new WaitForSeconds(tempoTransicao);

        SceneManager.LoadScene(index);
    }

}
