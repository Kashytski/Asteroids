using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusChecker : MonoBehaviour
{
    AudioSource soundHit;
    public Text healthText;
    public Text scoreText;
    public GameObject explosion;

    private void Start()
    {
        PlayerPrefs.SetInt("health", 3);
        PlayerPrefs.SetInt("score", 0);
        soundHit = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        healthText.text = $"health count: {PlayerPrefs.GetInt("health")}";
        scoreText.text = $"score: {PlayerPrefs.GetInt("score")}";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "meteor")
        {
            int health = PlayerPrefs.GetInt("health") - 1;
            PlayerPrefs.SetInt("health", health);

            Destroy(collision.gameObject);

            if (health == 0)
            {
                Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
                FixedUpdate();
                Destroy(gameObject);                
            }
            else
            {
                soundHit.Play();
            }
        }

    }
}
