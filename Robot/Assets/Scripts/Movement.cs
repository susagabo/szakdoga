using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float horizontalmove = 0f;
    public float force = 0f;
    float speed = 2f;
    //Vector3 facing;
    bool isFacingRight = true;
    bool isJumping = false;
    bool grounded = false;
    public Animator animator;
    public Rigidbody2D rb;


    void Flip()
    {
        isFacingRight = !isFacingRight;

        if (!PlayerHealth.isDead)
            transform.Rotate(0, 180, 0);

        //facing.x *= (-1);
        //transform.localScale = facing;
    }

    void Jump()
    {
        isJumping = true;
        grounded = false;
        animator.SetBool("grounded", grounded);
        animator.SetBool("jump", isJumping);
        //rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        rb.velocity = Vector2.up * force;


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") && grounded == false)
        {
            grounded = true;
            animator.SetBool("grounded", grounded);
            //isJumping = false;
            //animator.SetBool("jump", isJumping);

        }

    }

    private void Start()
    {
        //force = 5f;
        //facing = transform.localScale;

    }

    void FixedUpdate()
    {
        //grounded = Physics2D.OverlapBox();
        //ugrás
        if (Input.GetButtonDown("Jump") && grounded /*col.IsTouching(bcol)*/)
        {
            if (!PlayerHealth.isDead)
                Jump();
        }

        animator.SetBool("jump", isJumping);
        isJumping = false;


        //landolás 

        //if (col.IsTouching(bcol))
        {
            //isJumping = false;   ---------------WTF????????-----------
            //animator.SetBool("jump", isJumping);
            //isJumping = false;

        }

    }

    void Update()
    {
        horizontalmove = Mathf.Abs(Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed);

        //flip
        if (Input.GetAxisRaw("Horizontal") < 0 && isFacingRight)
        {
            Flip();
        }
        else
        {
            if (Input.GetAxisRaw("Horizontal") > 0 && !isFacingRight)
                Flip();
        }

        //mozgatás
        if (!PlayerHealth.isDead)
            transform.Translate(horizontalmove, 0, 0);

        //animálás
        animator.SetFloat("speed", Mathf.Abs(horizontalmove));
        //animator.SetBool("jump", isJumping);
    }
}
