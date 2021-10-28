using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTeleporter : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        float pos_x = collision.gameObject.transform.position.x;
        float pos_y = collision.gameObject.transform.position.y;
        
        if (collision.gameObject.tag != "projectile")
            switch (gameObject.tag)
            {
                case "border_x":
                    if (pos_y > 0)
                    {
                        pos_y--;
                    }
                    else
                    {
                        pos_y++;
                    }
                    collision.transform.position = new Vector3(pos_x, -pos_y, 0);
                    break;
                case "border_y":
                    if (pos_x > 0)
                    {
                        pos_x -= 0.5f;
                    }
                    else
                    {
                        pos_x += 0.5f;
                    }
                    collision.transform.position = new Vector3(-pos_x, pos_y, 0);
                    break;
            }
        else
        {
            Destroy(collision.gameObject);
        }
    }


}
