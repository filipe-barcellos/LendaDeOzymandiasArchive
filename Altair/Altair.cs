using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Altair : MonoBehaviour
{
    public float Speed;
    public float Jumpforce;
    private Rigidbody2D rig;
    private Animator anim;
    public bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        float movement = Input.GetAxis("AltairHorizontal");
        rig.velocity =  new Vector2(movement*Speed, rig.velocity.y);
        if(movement > 0)
        {
            anim.SetBool("walk",true);
            transform.eulerAngles = new Vector3(0f,0f,0f);
        }
        if(movement < 0)
        {
            anim.SetBool("walk",true);
            transform.eulerAngles = new Vector3(0f,180f,0f);
        }
        if(movement == 0)
        {
            anim.SetBool("walk",false);
        }
        Physics2D.IgnoreLayerCollision(6,7);
        Physics2D.IgnoreLayerCollision(7,9);
    }

    void Jump()
    {
        if(Input.GetButtonDown("AltairJump") && !isJumping)
        {
            rig.AddForce(new Vector2(0f,Jumpforce),ForceMode2D.Impulse);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer==8)
        {
            isJumping = false;
        }
        if(collision.gameObject.tag=="Espinhos")
        {
            GameController.instance.ShowGameOver();
            Destroy(gameObject);
        }
        if(collision.gameObject.tag=="Mumia")
        {
            GameController.instance.ShowGameOver();
            Destroy(gameObject);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.layer==8)
        {
            isJumping = true;
        }
    }
}