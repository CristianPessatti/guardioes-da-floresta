using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MataInimigo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "inimigo") {
            Object.Destroy(other.gameObject);
            Object.Destroy(gameObject);
        }
    }
}
