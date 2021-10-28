using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorRender : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;
    SpriteRenderer spriteRender;
    private int spriteNum;

    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
        spriteNum = Random.RandomRange(0, sprites.Length);
        spriteRender.sprite = sprites[spriteNum];
    }
}
