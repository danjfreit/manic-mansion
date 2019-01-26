using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FixableObject : MonoBehaviour
{
    public Sprite fixedSprite;
    public static Sprite badFixedSprite;

    private SpriteRenderer spriteRenderer;


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Fix()
    {
        spriteRenderer.sprite = fixedSprite;
    }
}
