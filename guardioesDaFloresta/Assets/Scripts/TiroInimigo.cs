using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroInimigo : MonoBehaviour
{

    public GameObject flecha;
    public Transform firePoint;

    public float delayTiro = 2f;
    private float nextShot = 0f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && Time.time > nextShot)
        {
            nextShot = Time.time + delayTiro;
            Instantiate(flecha, firePoint.position, firePoint.rotation);
        }
    }
}