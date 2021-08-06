using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MataPlayer : MonoBehaviour
{
    public float bulletSpeed = 1;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * bulletSpeed;
    }


    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<SaudeJogador>().dano(1);
            Object.Destroy(gameObject);
        }
    }
}
