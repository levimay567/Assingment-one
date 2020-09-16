using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float speed;
    SpriteRenderer SpriteRen;
    Animator Tankanim;

    //devlare verriables
    //
    
	// Use this for initialization
	void Start () {
        Debug.Log("hello");

        rb2d = GetComponent<Rigidbody2D>();
        SpriteRen = GetComponent<SpriteRenderer>();
        Tankanim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //get user input

        //if user pushes up move person up
        //check if up key is pressed
        //change velosity
        //play animateion

        //if user pushes down key move person up
        //check if up key is pressed
        //change velosity
        //play animateion
        //flip sprite y

        //if user pushes Right move person Right
        //check if up key is pressed
        //change velosity
        //play animateion

        //if userpushes up left person left
        //check if up key is pressed
        //change velosity
        //play animateion
        //flip sprite x



        ;
        if (Input.GetKey("w") || Input.GetKey("up") )
        {
            rb2d.velocity = new Vector2(0, speed);
            SpriteRen.flipY = false;
            Tankanim.Play("TankMoveUp");
        }
       else if (Input.GetKey("s") || Input.GetKey("down"))
        {
            rb2d.velocity = new Vector2(0, -speed);
            SpriteRen.flipY = true;
            Tankanim.Play("TankMoveUp");
        }
        else if (Input.GetKey("d")  || Input.GetKey("right") )
        {
            rb2d.velocity = new Vector2(speed, 0);
            SpriteRen.flipX = false;
            Tankanim.Play("TankMoveRight");
        }
        else if (Input.GetKey("a") || Input.GetKey("left") )
        {
            rb2d.velocity = new Vector2(-speed, 0);
            SpriteRen.flipX = true;
            Tankanim.Play("Tank" +
                "MoveRight");
        }
        else
        {
            rb2d.velocity = new Vector2(0, 0);
        }



    }
}
