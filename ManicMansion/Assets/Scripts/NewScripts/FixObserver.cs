using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tools;

[RequireComponent(typeof(Fixable))]
[RequireComponent(typeof(ToolComponent))]
public abstract class FixObserver : MonoBehaviour {
    protected ToolComponent toolComp;
    protected ToolInventory toolInv;

    protected void Awake() {
        toolComp = GetComponent<ToolComponent>();
        toolInv = FindObjectOfType<ToolInventory>();
    }

    private void Start() {
        GetComponent<Fixable>().AddObserver(this);
    }

    public abstract void OnFix(ToolEnum tool);
}
