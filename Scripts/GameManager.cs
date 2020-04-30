using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;



public class GameManager : MonoBehaviour
{
    //Loads scene corresponding to that number
    //0 - "_MainMenu"
    //1 - "MainScene" (GameLevel)
    public UiManager3 ui3;
    public Text submission;

    private void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
        ui3 = GameObject.FindWithTag("ui3").GetComponent<UiManager3>();
    }

    public void loadScene(int sceneNum){
        SceneManager.LoadScene(sceneNum);
    }

    //loads next scene in build index 
    public void nextScene(){
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }

    //quits game
    public void quitGame(){
        Application.Quit();
    }

    public void loadGame()
    {
        loadScene(1);
    }

    public void clickSubmitScore()
    {
        if(ui3.insertScore(PlayerPrefs.GetInt("LatestScore"), System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy@hh:mm tt")))
        {
            //submission.text = "Score Submitted! :)";
            loadScene(3);
        }
        else
        {
            submission.text = "Your score was too low to submit :(";
        }
    }

    
}
