using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelMenuScript : MonoBehaviour
{
    public static bool nextLevel_GamePaused = false;

    public GameObject NextLevelMenuUI;

    public Text LevelCompletedMessage;

    public Text CoinsAmountText;

    //public static int currentScene = 1;

    void Start()
    {
        nextLevel_GamePaused = false;
        LevelCompletedMessage.text = "Level " + SceneManager.GetActiveScene().buildIndex + " Completed";

        //currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("CurrentScene", SceneManager.GetActiveScene().buildIndex);
        
    }

    void Update()
    {
        CoinsAmountText.text = "Coins : " + GameManagement.coinsAmount;
        
        if (nextLevel_GamePaused)
        {
            
            Pause();
        }

    }

    void Pause()
    {
        NextLevelMenuUI.SetActive(true);
        Time.timeScale = 0;
        
    }

    public void LoadMainMenu()
    {
        
        Time.timeScale = 1f;
        //currentScene++;
        PlayerPrefs.SetInt("CurrentScene", SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("Menu");
       // mainMenu.TotalCoinsHave += PlayerPrefs.GetInt("AddingCoins");
    }

    public void NextLevelLoad()
    {
        if (SceneManager.GetActiveScene().buildIndex == 17)
        {
            
            SceneManager.LoadScene(0);
            //  mainMenu.TotalCoinsHave += PlayerPrefs.GetInt("AddingCoins"); 
        }
        else
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //mainMenu.TotalCoinsHave += PlayerPrefs.GetInt("AddingCoins");
        }
        
    }

}
