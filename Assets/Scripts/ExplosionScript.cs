using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    private void Start()
    {
        Invoke("Destroy",5f);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
