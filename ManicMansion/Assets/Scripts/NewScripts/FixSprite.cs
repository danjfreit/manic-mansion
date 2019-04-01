using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Fixable))]
public class FixSprite : MonoBehaviour, IFixObserver {
    public Sprite fixedSprite;

    SpriteRenderer spriteRenderer;

    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start() {
        GetComponent<Fixable>().AddObserver(this);
    }

    public void OnFix() {
        spriteRenderer.sprite = fixedSprite;
    }
}
