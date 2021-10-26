using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTeleporter : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("tp");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("tp");
            collision.gameObject.transform.position = new Vector3(0, 0, 0);
        }
    }
}
