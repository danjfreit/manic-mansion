// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using System;

// public class PlayerAction : MonoBehaviour
// {
//     public Sprite windowBadSprite;
//     public Sprite weedBadSprite;
//     public Sprite baldPatchBadSprite;
//     public Sprite raccoonBadSprite;


//     private ToolInventory tools;
//     private List<GameObject> houseObjects;

//     private void Awake()
//     {
//         tools = GetComponent<ToolInventory>();
//         houseObjects = new List<GameObject>();
//     }

//     private void Update()
//     {
//         if (Input.GetButtonDown("Button0"))
//             AttemptWindowFix();
//         if (Input.GetButtonDown("Button1"))
//             AttemptWeedFix();
//         if (Input.GetButtonDown("Button2"))
//             AttemptBaldPatchFix();
//         if (Input.GetButtonDown("Button3"))
//             AttemptRaccoonFix();
//     }

//     public void AttemptWindowFix()
//     {
//         GameObject fixableObj = houseObjects.Find(IsFixable<Window>);
//         if (fixableObj != null)
//         {
//             if (tools.WindowFix > 0)
//                 fixableObj.GetComponent<FixableObject>().Fix();
//             else
//                 fixableObj.GetComponent<FixableObject>().BadFix();
//         }
//         tools.WindowFix--;
//     }

//     public void AttemptWeedFix()
//     {
//         GameObject fixableObj = houseObjects.Find(IsFixable<Weed>);
//         if (fixableObj != null)
//         {
//             if (tools.WeedFix > 0)
//                 fixableObj.GetComponent<FixableObject>().Fix();
//             else
//                 fixableObj.GetComponent<FixableObject>().BadFix();
//         }
//         tools.WeedFix--;
//     }

//     public void AttemptBaldPatchFix()
//     {
//         GameObject fixableObj = houseObjects.Find(IsFixable<BaldPatch>);
//         if (fixableObj != null)
//         {
//             if (tools.BaldPatchFix > 0)
//                 fixableObj.GetComponent<FixableObject>().Fix();
//             else
//                 fixableObj.GetComponent<FixableObject>().BadFix();
//         }
//         tools.BaldPatchFix--;
//     }

//     public void AttemptRaccoonFix()
//     {
//         GameObject fixableObj = houseObjects.Find(IsFixable<Raccoon>);
//         if (fixableObj != null)
//         {
//             if (tools.RaccoonFix > 0)
//                 fixableObj.GetComponent<FixableObject>().Fix();
//             else
//                 fixableObj.GetComponent<FixableObject>().BadFix();
//         }
//         tools.RaccoonFix--;
//     }

//     public bool IsFixable<T>(GameObject obj) where T : FixableObject
//     {
//         if (obj.GetComponent<T>() != null)
//         {
//             return true;
//         }
//         return false;
//     }

//     // Use the collider to keep track of what objects are under the player 
//     private void OnTriggerEnter2D(Collider2D other)
//     {
//         if (!other.CompareTag("Player")) 
//         {
//             houseObjects.Add(other.gameObject);
//         }
//     }

//     private void OnTriggerExit2D(Collider2D other)
//     {
//         if (!other.CompareTag("Player"))
//         {
//             houseObjects.Remove(other.gameObject);
//         }
//     }
// }
