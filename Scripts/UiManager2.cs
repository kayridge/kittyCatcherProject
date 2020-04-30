using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager2 : MonoBehaviour
{

    int score = 0;
    public Text finalScoreText;
    

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("LatestScore", score);
        
    }

    // Update is called once per frame
    void Update()
    {
        score = PlayerPrefs.GetInt("LatestScore");

        finalScoreText.text = "Your Score: " + score;


    }
}
