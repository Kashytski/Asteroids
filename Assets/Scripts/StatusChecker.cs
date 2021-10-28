using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusChecker : MonoBehaviour
{
    AudioSource soundHit;
    [SerializeField] Text livesText;
    [SerializeField] Text scoreText;
    [SerializeField] GameObject explosion;

    private void Start()
    {
        PlayerPrefs.SetInt("lives", 3);
        PlayerPrefs.SetInt("score", 0);
        soundHit = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        livesText.text = $"lives: {PlayerPrefs.GetInt("lives")}";
        scoreText.text = $"score: {PlayerPrefs.GetInt("score")}";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "meteor")
        {
            int lives = PlayerPrefs.GetInt("lives") - 1;
            PlayerPrefs.SetInt("lives", lives);

            Destroy(collision.gameObject);

            if (lives == 0)
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
