using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{

    public Text aliveEnemynumber;

    public float waitingtime = 0f;

    
    GameObject[] coins;
    public static int coinsAmount = 0;

    GameObject[] enemies;

    public int StoreAllCoinDataForAddingNewCoins = 0;
    public int iffTotalCoins;

    // Start is called before the first frame update
    void Start()
    {
        coins = GameObject.FindGameObjectsWithTag("coin");
        coinsAmount = coins.Length;
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            
            PlayerPrefs.SetInt("AddingCoins", 0);
        }

        StoreAllCoinDataForAddingNewCoins = PlayerPrefs.GetInt("TotalCoinsHave");
        iffTotalCoins = coinsAmount+StoreAllCoinDataForAddingNewCoins;
    }

    // Update is called once per frame
    void Update()
    {

        coins = GameObject.FindGameObjectsWithTag("coin");
        //print(coins.Length);


        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //print(enemies.Length);

        foreach (GameObject r in coins)
        {

            if (r != null)
                r.transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
            
            
        }


        aliveEnemynumber.text = "Alive Enemy : " + enemies.Length;

        if (enemies.Length > 0 || coins.Length>0)
        {
            waitingtime = 0;
        }
       
        
        waitingtime += Time.deltaTime;

        

        if (enemies.Length== 0 && waitingtime >= 2 && coins.Length == 0)
        {
            NextLevelMenuScript.nextLevel_GamePaused = true;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //PlayerPrefs.SetInt("AddingCoins", coinsAmount);
            
            PlayerPrefs.SetInt("TotalCoinsHave",iffTotalCoins);
        }

    }


}


