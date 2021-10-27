using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public Transform[] spawn_pos;
    public GameObject meteor;
    private int spawnNum;

    public float timeDelay = 4.0f;
    private float timeStamp;

    void Update()
    {
        int spawn_x = Random.RandomRange(-8, 8);
        int spawn_y = Random.RandomRange(-5, 5);

        if (Time.time >= timeStamp)
        {
            spawnNum = Random.RandomRange(0, spawn_pos.Length);

            GameObject meteorMove = Instantiate(meteor, spawn_pos[spawnNum].transform.position, spawn_pos[spawnNum].transform.rotation);
            Rigidbody2D rigidBody = meteorMove.GetComponent<Rigidbody2D>();
            rigidBody.AddForce(new Vector2(spawn_x, spawn_y), ForceMode2D.Impulse);
            timeStamp = Time.time + timeDelay;
        }
    }
}
