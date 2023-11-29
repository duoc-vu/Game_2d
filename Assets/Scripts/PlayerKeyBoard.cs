using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyBoard : MonoBehaviour
{
    public float speed = 8f;
    public float maxVelocity = 4f;

    //[SerializeField]
    private Rigidbody2D rb2;
    private Animator anim;

    void Awake()
    {
        rb2= GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMoveBoard();
    }

    void PlayerMoveBoard()
    {
        float forceX = 0f;
        float vel = Mathf.Abs(rb2.velocity.x);

        float h = Input.GetAxisRaw("Horizontal");
        if(h > 0)
        {
            if(vel < maxVelocity)  forceX = speed;
            
            Vector3 temp = transform.localScale;
            temp.x = -1.3f;
            transform.localScale = temp;


            anim.SetBool("Walk", true);
        }
        else if(h<0)
        {
            if (vel < maxVelocity)  forceX = -speed;

            Vector3 temp = transform.localScale;
            temp.x = -1.3f;
            transform.localScale = temp;

            anim.SetBool("Walk", true);
        }else
        {
            anim.SetBool("Walk", false);
        }

        rb2.AddForce(new Vector2(forceX, 0));
    }
}
