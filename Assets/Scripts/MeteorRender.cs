using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorRender : MonoBehaviour
{
    public Sprite[] sprites;
    SpriteRenderer spriteRender;
    private int spriteNum;

    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
        spriteNum = Random.RandomRange(0, sprites.Length);
    }

    // Update is called once per frame
    void Update()
    {
        spriteRender.sprite = sprites[spriteNum];
    }
}
