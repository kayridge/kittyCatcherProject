using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public Text scoreText;
    public Text timeText;
    public int score = 0;
    int timeLeft = 1800;


    public void updateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }

    public void updateTime()
    {
        timeText.text = "Time: " + (timeLeft / 60);
        if (timeLeft > 0)
            timeLeft--;
        else 
        {
            PlayerPrefs.SetInt("LatestScore", score);
            SceneManager.LoadScene(2);
    
        }

    }




    // Start is called before the first frame update
    void Start()
    {
        //ui2 = GameObject.FindWithTag("ui2").GetComponent<UiManager2>();
    }

    // Update is called once per frame
    void Update()
    {

        updateTime();
        
    }

    //function to increase score will go here 

    //void displayScore()
    //{

    //}

}
