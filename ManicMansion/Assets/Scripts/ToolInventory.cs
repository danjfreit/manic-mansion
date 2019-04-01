using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tools;

public class ToolInventory : FixObserver {
    [Header("Starting Values (Edit Mode Only)")]
    public int BaldPatchCount;
    public int RaccoonCount;
    public int WeedCount;
    public int WindowCount;

    public Dictionary<ToolEnum, int> values;

    private new void Awake() {
        values = new Dictionary<ToolEnum, int>() {
            {ToolEnum.BaldPatch, BaldPatchCount},
            {ToolEnum.Raccoon, RaccoonCount},
            {ToolEnum.Weed, WeedCount},
            {ToolEnum.Window, WindowCount}
        };
    }

    private void Start() {
        Fixable.AddObserverStatic(this);
    }

    public override void OnFix(ToolEnum tool) {
        values[tool] = values[tool] - 1;
    }
}
