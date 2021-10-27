using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCollision : MonoBehaviour
{
    public GameObject soundCollision;
    public GameObject soundExplosion;
    public GameObject soundDestroy;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "meteor":
                Instantiate(soundCollision);
                break;
            case "Player":
                Instantiate(soundExplosion);
                break;
            case "projectile":
                Instantiate(soundDestroy);
                break;
        }
    }
}
