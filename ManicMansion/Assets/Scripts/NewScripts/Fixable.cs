using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

using Tools;

public class Fixable : MonoBehaviour {
    private List<FixObserver> observers;

    private void Awake() {
        observers = new List<FixObserver>();
    }
    // TEST CODE, TO BE REMOVED
    private void Update() {
        if (Time.time > 1.5f)
            Fix(ToolEnum.BaldPatch);
    }
    // END TEST CODE

    public void AddObserver(FixObserver observer) {
        observers.Add(observer);
    }

    public void RemoveObserver(FixObserver observer) {
        observers.Remove(observer);
    }

    public void Fix(ToolEnum tool) {
        foreach (FixObserver observer in observers) {
            observer.OnFix(tool);
        }

        this.enabled = false;
    }
}
