using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tools;

public class ToolInventory : MonoBehaviour {
    public int BaldPatchCount;
    public int RaccoonCount;
    public int WeedCount;
    public int WindowCount;

    public Dictionary<ToolEnum, int> values;

    private void Awake() {
        values = new Dictionary<ToolEnum, int>() {
            {ToolEnum.BaldPatch, BaldPatchCount},
            {ToolEnum.Raccoon, RaccoonCount},
            {ToolEnum.Weed, WeedCount},
            {ToolEnum.Window, WindowCount}
        };
    }
}
