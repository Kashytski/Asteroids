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

    int health;
    int score;

    private void Start()
    {
        health = 3;
        score = 0;
        PlayerPrefs.SetInt("score", score);
        soundHit = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        healthText.text = $"health count: {health}";
        scoreText.text = $"score: {PlayerPrefs.GetInt("score")}";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "meteor")
        {
            Destroy(collision.gameObject);
            if (health > 0)
            {
                soundHit.Play();
                health--;
            }
            else
            {                
                Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
                Destroy(gameObject);
            }
        }

    }
}
