using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectile;
    public Transform shootPoint;

    private float playerSpeed = 10f;
    private float horizontal;
    private float vertical;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        gameObject.transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * horizontal);
        gameObject.transform.Translate(Vector3.up * Time.deltaTime * playerSpeed * vertical);
        
        //Look at mouse
        var direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

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
