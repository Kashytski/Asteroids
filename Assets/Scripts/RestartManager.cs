using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class RestartManager : MonoBehaviour
{
    public GameObject restart;
    public GameObject spawner;
    public Text healthText;

    void Update()
    {
        int health = PlayerPrefs.GetInt("health");
        if (health == 0)
        {
            restart.SetActive(true);
            spawner.SetActive(false);
        }           

        if (Input.GetKeyDown(KeyCode.F5) && restart.activeInHierarchy == true)
        {
            SceneManager.LoadScene("GameZone");
        }
    }
}
