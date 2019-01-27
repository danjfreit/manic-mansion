using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerAction : MonoBehaviour
{
    public Sprite windowBadSprite;
    public Sprite weedBadSprite;
    public Sprite baldPatchBadSprite;
    public Sprite raccoonBadSprite;


    private ToolInventory tools;
    private List<GameObject> houseObjects;

    private void Awake()
    {
        tools = GetComponent<ToolInventory>();
        houseObjects = new List<GameObject>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Button0"))
            AttemptWindowFix();
        if (Input.GetButtonDown("Button1"))
            AttemptWeedFix();
        if (Input.GetButtonDown("Button2"))
            AttemptBaldPatchFix();
        if (Input.GetButtonDown("Button3"))
            AttemptRaccoonFix();
    }

    public void AttemptWindowFix()
    {
        if (tools.WindowFix > 0)
        {
            tools.WindowFix--;
            GameObject window = houseObjects.Find(IsFixable<Window>);
            if (window != null)
            {
                window.GetComponent<FixableObject>().Fix();
            }
        }
        else
        {
            GameObject badFixObj = 
                Instantiate(new GameObject(), transform.position, Quaternion.identity);
            SpriteRenderer badFixSprite = badFixObj.AddComponent<SpriteRenderer>();
            badFixSprite.sprite = windowBadSprite;
            badFixSprite.sortingLayerName = "BadFixes";
        }
    }

    public void AttemptWeedFix()
    {
        if (tools.WeedFix > 0)
        {
            tools.WeedFix--;
            GameObject weed = houseObjects.Find(IsFixable<Weed>);

            if (weed != null)
            {
                weed.GetComponent<FixableObject>().Fix();
            }
        }
        else
        {
            GameObject badFixObj =
                Instantiate(new GameObject(), transform.position, Quaternion.identity);
            SpriteRenderer badFixSprite = badFixObj.AddComponent<SpriteRenderer>();
            badFixSprite.sprite = weedBadSprite;
            badFixSprite.sortingLayerName = "BadFixes";
        }
    }

    public void AttemptBaldPatchFix()
    {
        if (tools.BaldPatchFix > 0)
        {
            tools.BaldPatchFix--;
            GameObject baldPatch = houseObjects.Find(IsFixable<BaldPatch>);
            if (baldPatch != null)
            {
                baldPatch.GetComponent<FixableObject>().Fix();
            }
        }
        else
        {
            GameObject badFixObj =
                Instantiate(new GameObject(), transform.position, Quaternion.identity);
            SpriteRenderer badFixSprite = badFixObj.AddComponent<SpriteRenderer>();
            badFixSprite.sprite = baldPatchBadSprite;
            badFixSprite.sortingLayerName = "BadFixes";
        }
    }

    public void AttemptRaccoonFix()
    {
        if (tools.RaccoonFix > 0)
        {
            tools.RaccoonFix--;
            GameObject raccoon = houseObjects.Find(IsFixable<Raccoon>);
            if (raccoon != null)
            {
                raccoon.GetComponent<FixableObject>().Fix();
            }
        }
        else
        {
            GameObject badFixObj =
                Instantiate(new GameObject(), transform.position, Quaternion.identity);
            SpriteRenderer badFixSprite = badFixObj.AddComponent<SpriteRenderer>();
            badFixSprite.sprite = raccoonBadSprite;
            badFixSprite.sortingLayerName = "BadFixes";
        }
    }

    public bool IsFixable<T>(GameObject obj) where T : FixableObject
    {
        if (obj.GetComponent<T>() != null)
        {
            return true;
        }
        return false;
    }

    // Use the collider to keep track of what objects are under the player 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) 
        {
            houseObjects.Add(other.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
        {
            houseObjects.Remove(other.gameObject);
        }
    }
}
