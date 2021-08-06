using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPlataforma : MonoBehaviour
{
    public GameObject inimigo;
    public GameObject[] pontos;

    public float speed = 5f;
    public float delay = 2f;

    public bool loop = true;

    private Transform transform;
    private int i = 0;
    private float nextDelay;
    private bool isMoving = true;

    void Start()
    {
        transform = inimigo.transform;
        nextDelay = 0f;
        isMoving = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextDelay)
        {
            if (!isMoving)
            {
                isMoving = true;
            }
        }
        movimenta();
    }

    void movimenta()
    {
        if ((pontos.Length != 0) && isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, pontos[i].transform.position, speed * Time.deltaTime);

            if (Vector3.Distance(pontos[i].transform.position, transform.position) <= 0.0001f)
            {
                i++;
                nextDelay = Time.time + delay;
                isMoving = false;
            }
        }

        if (i >= pontos.Length)
        {
            if (loop)
                i = 0;
            else
                isMoving = false;
        }
    }
}
