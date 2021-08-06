using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public float speed = 10f;
    public float jumpHeight = 20f;

    public Transform groundCheck;
    public LayerMask ground;

    public Animator animator;

    private float moveX;
    private bool facingRight = true;
    private bool isGrounded;
    private bool virar = false;

    void Start() {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update() {
        movePlayer();    
    }

    void LateUpdate() {
        faceSide();
    }

    void movePlayer() {
        moveX = Input.GetAxis("Horizontal");
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * speed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    
        isGrounded = Physics2D.Linecast(transform.position, groundCheck.position, ground);

        if(Input.GetButtonDown("Jump") && isGrounded)
            jump();

        // ANIMACOES
        animator.SetBool("IsGrounded", isGrounded);
        animator.SetBool("Correndo", moveX != 0);

        // ATAQUE
        // if(Input.GetMouseButtonDown(0))
            // animator.SetTrigger("Ataque");
    }

    void jump() {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpHeight);
    }

     void faceSide() {
         if(moveX > 0)
             facingRight = true;
         else if(moveX < 0)
             facingRight = false;

        Quaternion escala = transform.localRotation;
        Debug.Log(escala.y);
        if ((escala.y < 0.5 && !facingRight) || (escala.y > 0.5 && facingRight)) {
             escala.y = virar ? 180 : 0;
             virar = !virar;
             transform.localRotation = escala;
         }
    }

    // void OnCollisionEnter2D(Collision2D other) {
    //     if(other.gameObject.tag == "PlataformaMovel") 
    //         this.transform.parent = other.transform;
    // }

    // void OnCollisionExit2D(Collision2D other) {
    //     if(other.gameObject.tag == "PlataformaMovel") 
    //         this.transform.parent = null;
    // }
}
