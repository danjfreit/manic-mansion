using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Fixable : MonoBehaviour {
    private List<IFixObserver> observers;

    private void Awake() {
        observers = new List<IFixObserver>();
    }

    private void Update() {
        if (Time.time > 1.5f)
            Fix();
    }

    public void AddObserver(IFixObserver observer) {
        observers.Add(observer);
    }

    public void RemoveObserver(IFixObserver observer) {
        observers.Remove(observer);
    }

    public void Fix() {
        foreach (IFixObserver observer in observers) {
            observer.OnFix();
        }
    }
}
