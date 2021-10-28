using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusChecker : MonoBehaviour
{
    AudioSource soundHit;
    public Text lifeText;
    public Text scoreText;
    public GameObject explosion;

    private void Start()
    {
        PlayerPrefs.SetInt("life", 3);
        PlayerPrefs.SetInt("score", 0);
        soundHit = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        lifeText.text = $"Life: {PlayerPrefs.GetInt("life")}";
        scoreText.text = $"score: {PlayerPrefs.GetInt("score")}";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "meteor")
        {
            int life = PlayerPrefs.GetInt("life") - 1;
            PlayerPrefs.SetInt("life", life);

            Destroy(collision.gameObject);

            if (life == 0)
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
