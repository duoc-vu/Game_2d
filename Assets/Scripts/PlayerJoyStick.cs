using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoyStick : MonoBehaviour
{

    public float speed = 8f;
    public float maxVelocity = 4f;

    //[SerializeField]
    private Rigidbody2D rb2;
    private Animator anim;

    void Awake()
    {
        rb2 = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
     private bool moveRight, moveLeft;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if(moveLeft) { MoveLeft();}
        if(moveRight) { MoveRight();}
    }

    public void setMoveLeft(bool moveLeft)
    {
        this.moveLeft = moveLeft;
        this.moveRight = !moveLeft;
    }

    public void stopMoving()
    {
        moveLeft= moveRight=false;
        anim.SetBool("Walk", false);
    }


    void MoveLeft() {
        float forceX = 0f;
        float vel = Mathf.Abs(rb2.velocity.x);

        if (vel < maxVelocity) forceX = -speed;

        Vector3 temp = transform.localScale;
        temp.x = -9.4477f;
        transform.localScale = temp;

        anim.SetBool("Walk", true);

        rb2.AddForce(new Vector2(forceX, 0));
    }
    void MoveRight() {
        float forceX = 0f;
        float vel = Mathf.Abs(rb2.velocity.x);

        if (vel < maxVelocity) forceX = speed;

        Vector3 temp = transform.localScale;
        temp.x = 9.4477f;
        transform.localScale = temp;

        anim.SetBool("Walk", true);

        rb2.AddForce(new Vector2(forceX, 0));
    }
}
