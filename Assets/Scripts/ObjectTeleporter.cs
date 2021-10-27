using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTeleporter : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        float pos_x = collision.gameObject.transform.position.x;
        float pos_y = collision.gameObject.transform.position.y;
        float pos_z = collision.gameObject.transform.position.z;
        
        if (collision.gameObject.tag != "projectile")
            switch (gameObject.tag)
            {
                case "border_x":
                    collision.transform.position = new Vector3(pos_x, -pos_y, pos_z);
                    break;
                case "border_y":
                    collision.transform.position = new Vector3(-pos_x, pos_y, pos_z);
                    break;
            }
        else
        {
            Destroy(collision.gameObject);
        }
    }


}
