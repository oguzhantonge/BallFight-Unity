using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelonCollision : MonoBehaviour
{
    //public static int currentScene=1;

    [SerializeField] string strTag;

    void Start()
    {
        //currentScene = SceneManager.GetActiveScene().buildIndex;

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == strTag)
        {
            //SceneManager.SetActiveScene(SceneManager.GetActiveScene().name);

            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene(0);
        }
    }

}
