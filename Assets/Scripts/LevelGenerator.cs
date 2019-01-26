using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

[Serializable]
public struct SpawnInfo
{
	public GameObject thingToSpawn;
	public Vector2 amountToSpawn;
	public Vector2 xStartRange;
	public Vector2 xAdditionRange;
	public Vector2 yVariance;

	public int GetAmount => Random.Range((int) amountToSpawn.x, (int) amountToSpawn.y);
	public float GetXStart => Random.Range(xStartRange.x, xStartRange.y);
	public float GetXAddition => Random.Range(xAdditionRange.x, xAdditionRange.y);
	public float GetYVariance => Random.Range(yVariance.x, yVariance.y);
}

public class LevelGenerator : MonoBehaviour
{
	public GameObject Background;

	// TODO: replace with the interactive objects.
	public SpawnInfo WindowInfo;

	public SpawnInfo PaintInfo;

	public SpawnInfo WeedInfo;

	public SpawnInfo RacoonInfo;

	public float EndGameDistance = 56;

	public GameObject EndGameArt;

	private void Awake()
	{
		for (var i = 0; i < 8; ++i)
		{
			Instantiate(Background, Vector3.right * i * 7.5f, Quaternion.identity);
		}

		Instantiate(EndGameArt, Vector3.right * 8 * 7.25f, Quaternion.identity);

		var t = DateTime.UtcNow - new DateTime(1970, 1, 1);
		Random.InitState((int) t.TotalSeconds);
		SpawnTheThings(WindowInfo);
		SpawnTheThings(PaintInfo);
		SpawnTheThings(WeedInfo);
		SpawnTheThings(RacoonInfo);
	}

	private void SpawnTheThings(SpawnInfo info)
	{
		var numWindow = info.GetAmount;
		var x = info.GetXStart;
		for (var i = 0; i < numWindow; ++i)
		{
			if (x < EndGameDistance)
			{
				Instantiate(info.thingToSpawn, new Vector3(x, info.GetYVariance, 0), Quaternion.identity);
				x += info.GetXAddition;
			}
		}
	}
}