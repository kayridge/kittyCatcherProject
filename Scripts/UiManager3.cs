using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager3 : MonoBehaviour
{

    public Text score1Text, score2Text, score3Text, score4Text, score5Text;
    public int score1Val, score2Val, score3Val, score4Val, score5Val;
    public string score1String, score2String, score3String, score4String, score5String;
    // Start is called before the first frame update
    void Start()
    {
        score1String = PlayerPrefs.GetString("score1Date", "Empty");
        score2String = PlayerPrefs.GetString("score2Date", "Empty");
        score3String = PlayerPrefs.GetString("score3Date", "Empty");
        score4String = PlayerPrefs.GetString("score4Date", "Empty");
        score5String = PlayerPrefs.GetString("score5Date", "Empty");

        score1Val = PlayerPrefs.GetInt("score1Val", 0);
        score2Val = PlayerPrefs.GetInt("score2Val", 0);
        score3Val = PlayerPrefs.GetInt("score3Val", 0);
        score4Val = PlayerPrefs.GetInt("score4Val", 0);
        score5Val = PlayerPrefs.GetInt("score5Val", 0);

        

    }

    public void resetScores()
    {
        PlayerPrefs.SetString("score1Date", "Empty");
        PlayerPrefs.SetString("score2Date", "Empty");
        PlayerPrefs.SetString("score3Date", "Empty");
        PlayerPrefs.SetString("score4Date", "Empty");
        PlayerPrefs.SetString("score5Date", "Empty");
        PlayerPrefs.SetInt("score1Val", 0);
        PlayerPrefs.SetInt("score2Val", 0);
        PlayerPrefs.SetInt("score3Val", 0);
        PlayerPrefs.SetInt("score4Val", 0);
        PlayerPrefs.SetInt("score5Val", 0);


        score1String = PlayerPrefs.GetString("score1Date", "Empty");
        score2String = PlayerPrefs.GetString("score2Date", "Empty");
        score3String = PlayerPrefs.GetString("score3Date", "Empty");
        score4String = PlayerPrefs.GetString("score4Date", "Empty");
        score5String = PlayerPrefs.GetString("score5Date", "Empty");

        score1Val = PlayerPrefs.GetInt("score1Val", 0);
        score2Val = PlayerPrefs.GetInt("score2Val", 0);
        score3Val = PlayerPrefs.GetInt("score3Val", 0);
        score4Val = PlayerPrefs.GetInt("score4Val", 0);
        score5Val = PlayerPrefs.GetInt("score5Val", 0);
    }

    public bool insertScore(int score, string date)
    {
        if (score > score1Val)
        {
            score5Val = score4Val;
            score4Val = score3Val;
            score3Val = score2Val;
            score2Val = score1Val;
            score1Val = score;

            score5String = score4String;
            score4String = score3String;
            score3String = score2String;
            score2String = score1String;
            score1String = date;

            PlayerPrefs.SetString("score1Date", score1String);
            PlayerPrefs.SetString("score2Date", score2String);
            PlayerPrefs.SetString("score3Date", score3String);
            PlayerPrefs.SetString("score4Date", score4String);
            PlayerPrefs.SetString("score5Date", score5String);
            PlayerPrefs.SetInt("score1Val", score1Val);
            PlayerPrefs.SetInt("score2Val", score2Val);
            PlayerPrefs.SetInt("score3Val", score3Val);
            PlayerPrefs.SetInt("score4Val", score4Val);
            PlayerPrefs.SetInt("score5Val", score5Val);

            return true;
        }

        if (score > score2Val)
        {
            score5Val = score4Val;
            score4Val = score3Val;
            score3Val = score2Val;
            score2Val = score;

            score5String = score4String;
            score4String = score3String;
            score3String = score2String;
            score2String = date;

            PlayerPrefs.SetString("score2Date", score2String);
            PlayerPrefs.SetString("score3Date", score3String);
            PlayerPrefs.SetString("score4Date", score4String);
            PlayerPrefs.SetString("score5Date", score5String);
            PlayerPrefs.SetInt("score2Val", score2Val);
            PlayerPrefs.SetInt("score3Val", score3Val);
            PlayerPrefs.SetInt("score4Val", score4Val);
            PlayerPrefs.SetInt("score5Val", score5Val);

            return true;
        }

        if (score > score3Val)
        {
            score5Val = score4Val;
            score4Val = score3Val;
            score3Val = score;

            score5String = score4String;
            score4String = score3String;
            score3String = date;

            PlayerPrefs.SetString("score3Date", score3String);
            PlayerPrefs.SetString("score4Date", score4String);
            PlayerPrefs.SetString("score5Date", score5String);
            PlayerPrefs.SetInt("score3Val", score3Val);
            PlayerPrefs.SetInt("score4Val", score4Val);
            PlayerPrefs.SetInt("score5Val", score5Val);

            return true;
        }

        if (score > score4Val)
        {
            score5Val = score4Val;
            score4Val = score;

            score5String = score4String;
            score4String = date;

            PlayerPrefs.SetString("score4Date", score4String);
            PlayerPrefs.SetString("score5Date", score5String);
            PlayerPrefs.SetInt("score4Val", score4Val);
            PlayerPrefs.SetInt("score5Val", score5Val);

            return true;
        }

        if (score > score5Val)
        {
            score5Val = score;

            score5String = date;

            PlayerPrefs.SetString("score5Date", score5String);
            PlayerPrefs.SetInt("score5Val", score5Val);

            return true;
        }

        return false;
    }


    // Update is called once per frame
    void Update()
    {
        score1Text.text = score1String + ": " + score1Val.ToString();
        score2Text.text = score2String + ": " + score2Val.ToString();
        score3Text.text = score3String + ": " + score3Val.ToString();
        score4Text.text = score4String + ": " + score4Val.ToString();
        score5Text.text = score5String + ": " + score5Val.ToString();
    }
}
