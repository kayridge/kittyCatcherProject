﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteCat : MonoBehaviour
{
    Rigidbody2D rb;
    float moveSpeed = 80f;
    int MovementFrameCounter = 0;
    int worth = 100;
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
                //GO UP
                rb.AddForce(new Vector2(0f, moveSpeed));
                MovementFrameCounter++;
                break;
            case 60:
                //go down
                rb.AddForce(new Vector2(0f, -2*moveSpeed));
                MovementFrameCounter++;
                break;
            case 120:
                //stop
                rb.AddForce(new Vector2(0f, moveSpeed));
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
