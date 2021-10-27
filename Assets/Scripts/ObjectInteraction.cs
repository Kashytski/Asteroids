using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    AudioSource sound;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sound.Play();
        if (collision.gameObject.tag == "projectile")
        {
            int score = PlayerPrefs.GetInt("score") + 10;
            PlayerPrefs.SetInt("score",score);

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
