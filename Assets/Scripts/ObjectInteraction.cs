using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    AudioSource sound;
    private void Start()
    {
        sound = gameObject.GetComponent<AudioSource>();    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "meteor")
        {
            sound.Play();

            if (gameObject.tag == "projectile")
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
    }
}
