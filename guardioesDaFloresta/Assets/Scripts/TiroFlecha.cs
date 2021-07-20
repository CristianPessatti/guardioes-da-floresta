using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroFlecha : MonoBehaviour
{
    public GameObject flecha;
    public Transform firePoint;

	public float delayAfterShot = 1.5f;
	private float nextShot = 0.0f;

    void Update()
    {

        if (Input.GetMouseButtonDown(0) && Time.time > nextShot)
        {
            nextShot = Time.time + delayAfterShot;

            Atirar();
        }
    }

    void Atirar()
    {
        Instantiate(flecha, firePoint.position, firePoint.rotation);
    }
}
