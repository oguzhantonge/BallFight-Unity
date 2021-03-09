using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    public Text TotalCoins;
    
    void Start()
    {

        
    }
    void Update()
    {
        
        //PlayerPrefs.SetInt("TotalCoinsHave", 0);
        TotalCoins.text = "Coins : " + PlayerPrefs.GetInt("TotalCoinsHave");
        // PlayerPrefs.SetInt("CurrentScene", 1);

    }
    public void PlayGame()
    {
        //SceneManager.LoadScene(NextLevelMenuScript.currentScene);
        SceneManager.LoadScene(PlayerPrefs.GetInt("CurrentScene"));
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResetLevels()
    {
        PlayerPrefs.SetInt("CurrentScene", 1); // Gelinen levelleri sıfırlar , 1.levelden başlatır.
    }

    public void ResetCoins()
    {
        PlayerPrefs.SetInt("TotalCoinsHave", 0);
    }


} // class










