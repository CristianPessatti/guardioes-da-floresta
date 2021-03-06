using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllEnemy : MonoBehaviour
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
    private bool virar = true;

    public GameObject flecha;
    public Transform firePoint;

    public float delayTiro = 2f;
    private float nextShot = 0f;

    private Animator animator;

    void Start() {
        transform = inimigo.transform;
        nextDelay = 0f;
        isMoving = true;
        animator = inimigo.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
            if(Time.time >= nextDelay) {
                if(!isMoving) {
                    Quaternion escala = transform.localRotation;
                    escala.y = (virar) ? 180 : 0;
                    virar = !virar;
                    transform.localRotation = escala;
                    isMoving = true;
                }
            }
            movimenta();
    }

    void movimenta() {
        if((pontos.Length != 0) && isMoving) {
            transform.position = Vector3.MoveTowards(transform.position, pontos[i].transform.position, speed * Time.deltaTime);

            animator.SetBool("isMoving", true);

            if(Vector3.Distance(pontos[i].transform.position, transform.position) <= 0.0001f) {
                i++;
                nextDelay = Time.time + delay;
                isMoving = false;
                animator.SetBool("isMoving", false);
            }
        }

        if(i >= pontos.Length) {
            if(loop)
                i = 0;
            else
                isMoving = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) //&& Time.time > nextShot
        {
            nextShot = Time.time + delayTiro;
            Instantiate(flecha, firePoint.position, firePoint.rotation);
        }
    }
}
