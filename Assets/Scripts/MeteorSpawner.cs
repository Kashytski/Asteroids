using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public Transform[] spawn_pos;
    public GameObject meteor;
    private int spawnNum;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnNum = Random.RandomRange(0, spawn_pos.Length);
        GameObject meteorMove = Instantiate(meteor, spawn_pos[spawnNum].transform.position, spawn_pos[spawnNum].transform.rotation);
        Rigidbody2D rigidBody = meteorMove.GetComponent<Rigidbody2D>();
        //rigidBody.AddForce(spawn_pos[spawnNum].transform.up * 20f, ForceMode2D.Impulse);
    }
}
