using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tools;


public class FixSprite : FixObserver {
    public Sprite fixedSprite;

    private SpriteRenderer spriteRenderer;

    protected new void Awake() {
        base.Awake();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public override void OnFix(GameTool tool) {
        if (tool == toolType.tool)
            spriteRenderer.sprite = fixedSprite;
    }
}
