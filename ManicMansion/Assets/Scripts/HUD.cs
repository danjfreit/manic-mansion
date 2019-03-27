using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
	public UnityEngine.UI.Text WindowCount;
	public UnityEngine.UI.Text PaintCount;
	public UnityEngine.UI.Text WeedCount;
	public UnityEngine.UI.Text RacoonCount;
	public ToolInventory Inventory;

	public void Update()
	{
		WindowCount.text = Inventory.WindowFix.ToString();
		PaintCount.text = Inventory.BaldPatchFix.ToString();
		WeedCount.text = Inventory.WeedFix.ToString();
		RacoonCount.text = Inventory.RaccoonFix.ToString();
	}
}