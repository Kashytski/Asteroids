using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] meteors;
    private int meteorType;

    private float timeDelay = 1.5f;
    private float timeStamp;

    Vector3 posSpawn;
    Quaternion posRotation = new Quaternion(0, 0, 0, 0);

    void Update()
    {
        if (Time.time >= timeStamp)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        int force_x = Random.RandomRange(-10,10);
        int force_y = Random.RandomRange(-10, 10);
        int spawn_xy = Random.RandomRange(0,1);  

        if (spawn_xy == 0)
        {
            int spawn_x = Random.RandomRange(-11, 11);
            posSpawn = new Vector3(spawn_x,7.5f,0);
        }
        else
        {
            int spawn_y = Random.RandomRange(-7,7);
            posSpawn = new Vector3(11.5f,spawn_y,0);
        }

        meteorType = Random.RandomRange(0, meteors.Length);

        GameObject meteorMove = Instantiate(meteors[meteorType], posSpawn, posRotation);
        Rigidbody2D rigidBody = meteorMove.GetComponent<Rigidbody2D>();
        rigidBody.AddForce(new Vector2(force_x, force_y), ForceMode2D.Impulse);
        timeStamp = Time.time + timeDelay;
    }
}
