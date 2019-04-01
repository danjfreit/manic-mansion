using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tools;


public class FixSound : FixObserver {
    public AudioClip fixedSound;
    public AudioClip badFixedSound;

    private AudioSource audioSource;

    private new void Awake() {
        base.Awake();
        audioSource = FindObjectOfType<AudioSource>();
    }

    public override void OnFix(ToolEnum tool) {
        if (tool == toolComp.tool) {
            if (toolInv.values[toolComp.tool] > 0)
                audioSource.PlayOneShot(fixedSound);
            else
                audioSource.PlayOneShot(badFixedSound);
        }
    }
}
