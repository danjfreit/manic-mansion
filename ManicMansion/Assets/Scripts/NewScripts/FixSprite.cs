using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tools;

[RequireComponent(typeof(Fixable))]
[RequireComponent(typeof(ToolType))]
public class FixSprite : MonoBehaviour, IFixObserver {
    public Sprite fixedSprite;

    ToolType toolType;
    SpriteRenderer spriteRenderer;

    private void Awake() {
        toolType = GetComponent<ToolType>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start() {
        GetComponent<Fixable>().AddObserver(this);
    }

    public void OnFix(GameTool tool) {
        if (tool == toolType.tool)
            spriteRenderer.sprite = fixedSprite;
    }
}
