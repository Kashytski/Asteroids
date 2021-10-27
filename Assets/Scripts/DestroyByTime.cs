using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour
{
    public int timeDestroy = 1;
    void Start()
    {
        Invoke("Destroy", timeDestroy);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
