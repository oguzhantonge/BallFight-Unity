using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CharacterSelection : MonoBehaviour
{
    private GameObject[] characterList;

    private int index;

    private void Start()
    {

        index = PlayerPrefs.GetInt("CharacterSelected");

        characterList = new GameObject[transform.childCount];

        //Fill the array with our models
        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }

        //We toggle of their renderer
        foreach (GameObject go in characterList)
        {
            go.SetActive(false); // SetActive false diyerek ekranda görünmemesini sağladık.
        }

        // We toggle on the selected character
        if (characterList[index])
        {
            characterList[index].SetActive(true);
        }

    }


    public void ToggleLeft()
    {
        // Toggle of the current model
        characterList[index].SetActive(false); // Öncelikle değiştirmeyi düşündüğümüz güncel karakteri görünmez yaptık.

        index--;
        if (index < 0)
        {
            index = characterList.Length - 1;
        }

        // Toggle on the new model
        characterList[index].SetActive(true); // Yeni karakterimizi aktif etmiş olduk.

        PlayerPrefs.SetInt("CharacterSelected", index);

    }

    public void ToggleRight()
    {
        // Toggle of the current model
        characterList[index].SetActive(false); // Öncelikle değiştirmeyi düşündüğümüz güncel karakteri görünmez yaptık.

        index++;
        if (index == characterList.Length)
        {
            index = 0;
        }

        // Toggle on the new model
        characterList[index].SetActive(true); // Yeni karakterimizi aktif etmiş olduk.

        PlayerPrefs.SetInt("CharacterSelected", index);

    }

    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("CharacterSelected", index);

        SceneManager.LoadScene("Game");
    }

} // class
