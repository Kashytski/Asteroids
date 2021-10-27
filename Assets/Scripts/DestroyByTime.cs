using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour
{
    void Start()
    {
        Invoke("Destroy",1f);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
