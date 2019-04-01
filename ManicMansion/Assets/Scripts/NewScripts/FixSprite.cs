using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tools;


public class FixSprite : FixObserver {
    public Sprite fixedSprite;
    public Sprite badFixedSprite;

    private SpriteRenderer spriteRenderer;

    private new void Awake() {
        base.Awake();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public override void OnFix(ToolEnum tool) {
        if (tool == toolComp.tool) {
            if (toolInv.values[toolComp.tool] > 0)
                spriteRenderer.sprite = fixedSprite;
            else
                spriteRenderer.sprite = badFixedSprite;
        }
    }
}
