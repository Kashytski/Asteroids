using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusChecker : MonoBehaviour
{
    public Text healthText;
    public Text scoreText;
    public GameObject explosion;

    int health { get; set; }
    int score { get; set; }

    private void Start()
    {
        health = 3;
        score = 0;
    }

    void FixedUpdate()
    {
        healthText.text = $"health count: {health}";
        scoreText.text = $"score: {score}";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "meteor")
        {
            Destroy(collision.gameObject);
            if (health > 0)
            {
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
