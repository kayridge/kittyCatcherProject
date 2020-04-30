using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catMoveTryTwo : MonoBehaviour
{
    Rigidbody2D rb;
    float moveSpeed = 40f;
    int MovementFrameCounter = 0;
    int worth = 150;
    public UiManager ui;
    public PlayerController player;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ui = GameObject.FindWithTag("ui").GetComponent<UiManager>();
        player = GameObject.FindWithTag("Player").GetComponent<PlayerController>();

    }

    private void OnDestroy()
    {
        player.play_sound();
        ui.updateScore(worth);
    }

    private void FixedUpdate()
    {
        //movement logic
        switch(MovementFrameCounter)
        {
            case 0:
                //GO UP
                rb.AddForce(new Vector2(0f, moveSpeed));
                MovementFrameCounter++;
                break;
            case 120:
                //stop up, go right
                rb.AddForce(new Vector2(moveSpeed, -moveSpeed));
                MovementFrameCounter++;
                break;
            case 240:
                //stop right, go down
                rb.AddForce(new Vector2(-moveSpeed, -moveSpeed));
                MovementFrameCounter++;
                break;
            case 360:
                //stop down, go left
                rb.AddForce(new Vector2(-moveSpeed, moveSpeed));
                MovementFrameCounter++;
                break;
            case 480:
                //stop left
                rb.AddForce(new Vector2(moveSpeed, 0f));
                //last movement, so reset counter for looped movement
                MovementFrameCounter = 0;
                worth = (int)(worth * 0.9);
                break;
            default:
                //coasting... do not change movement vector, increment frame counter
                MovementFrameCounter++;
                break;

        }
    }
}
