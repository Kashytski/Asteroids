using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float playerSpeed = 10f;
    private float horizontal;
    private float vertical;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        gameObject.transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * horizontal);
        gameObject.transform.Translate(Vector3.up * Time.deltaTime * playerSpeed * vertical);
    }
}
