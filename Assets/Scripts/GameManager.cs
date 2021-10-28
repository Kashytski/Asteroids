using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject restartText;
    [SerializeField] GameObject meteorSpawner;

    void Update()
    {
        int lives = PlayerPrefs.GetInt("lives");
        if (lives == 0)
        {
            restartText.SetActive(true);
            meteorSpawner.SetActive(false);
        }           

        if (Input.GetKeyDown(KeyCode.F5) && restartText.activeInHierarchy == true)
        {
            SceneManager.LoadScene("GameZone");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
