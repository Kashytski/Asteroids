using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public GameObject soundSource;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "meteor")
        {
            Instantiate(soundSource);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
