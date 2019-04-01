using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tools;

[RequireComponent(typeof(Fixable))]
[RequireComponent(typeof(ToolType))]
public abstract class FixObserver : MonoBehaviour {
    protected ToolType toolType;

    protected void Awake() {
        toolType = GetComponent<ToolType>();
    }

    private void Start() {
        GetComponent<Fixable>().AddObserver(this);
    }

    public abstract void OnFix(GameTool tool);
}
