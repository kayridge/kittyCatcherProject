using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public int playerStateInt = 2;
    public Animator playerAnim;

    public AudioSource source;

    Rigidbody2D rb;
    float moveSpeed = 5f;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
    }
    
    public void movement(int num){

        //playerStateInt = 0;

        switch(num){
            //UP
            case 1:
                rb.AddForce(new Vector2(0f, moveSpeed));
                playerAnim.SetInteger("playerStateInt", 2);
                //playerStateInt = 2;
                //play_sound();
                return;
            //LEFT
            case 2:
                rb.AddForce(new Vector2(-moveSpeed, 0f));
                playerAnim.SetInteger("playerStateInt", 8);
                //playerStateInt = 8;
                return;
            //DOWN
            case 3:
                rb.AddForce(new Vector2(0f, -moveSpeed));
                playerAnim.SetInteger("playerStateInt", 4);
                //playerStateInt = 4;
                return;
            //RIGHT
            case 4:
                rb.AddForce(new Vector2(moveSpeed, 0f));
                playerAnim.SetInteger("playerStateInt", 6);
                //playerStateInt = 6;
                return;
            default:
                playerAnim.SetInteger("playerStateInt", 0);
                return;
        }

    }

    public void play_sound()
    {
            source.Play();
    }
    
}