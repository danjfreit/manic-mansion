using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FixableObject : MonoBehaviour
{
    public Sprite fixedSprite;
    public Sprite badFixedSprite;

    [Space]
    public AudioClip fixedClip;
    public AudioClip badFixedClip;

    private SpriteRenderer spriteRenderer;
    private AudioSource audioSource;



    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = FindObjectOfType<AudioSource>();
    }

    public void Fix()
    {
        spriteRenderer.sprite = fixedSprite;
        audioSource.PlayOneShot(fixedClip, 2f);
    }

    public void BadFix()
    {
        spriteRenderer.sprite = badFixedSprite;
        audioSource.PlayOneShot(badFixedClip, 2f);
    }
}
