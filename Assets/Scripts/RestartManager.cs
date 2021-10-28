using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class RestartManager : MonoBehaviour
{
    public GameObject restartText;
    public GameObject meteorSpawner;

    void Update()
    {
        int life = PlayerPrefs.GetInt("life");
        if (life == 0)
        {
            restartText.SetActive(true);
            meteorSpawner.SetActive(false);
        }           

        if (Input.GetKeyDown(KeyCode.F5) && restartText.activeInHierarchy == true)
        {
            SceneManager.LoadScene("GameZone");
        }
    }
}
