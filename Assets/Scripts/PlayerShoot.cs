using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject projectile;
    public Transform shootPoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject shot = Instantiate(projectile, shootPoint.transform.position, shootPoint.transform.rotation);
        Rigidbody2D rigidBody = shot.GetComponent<Rigidbody2D>();
        rigidBody.AddForce(shootPoint.transform.up * 20f, ForceMode2D.Impulse);
    }
}
