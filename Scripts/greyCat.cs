using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greyCat : MonoBehaviour
{
    Rigidbody2D rb;
    float moveSpeed = 100f;
    int MovementFrameCounter = 0;
    int worth = 250;
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
        switch (MovementFrameCounter)
        {
            case 0:
                //GO UP, right
                rb.AddForce(new Vector2(moveSpeed, moveSpeed));
                MovementFrameCounter++;
                break;
            case 60:
                //go down, continue right
                rb.AddForce(new Vector2(0f, -2*moveSpeed));
                MovementFrameCounter++;
                break;
            case 120:
                //go left, continue down
                rb.AddForce(new Vector2(-2*moveSpeed, 0f));
                MovementFrameCounter++;
                break;
            case 180:
                //continue left, go up
                rb.AddForce(new Vector2(0f, 2*moveSpeed));
                MovementFrameCounter++;
                break;
            case 240:
                //stop left, stop up
                rb.AddForce(new Vector2(moveSpeed, -moveSpeed));
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
