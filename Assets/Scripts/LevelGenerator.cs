using System;
using UnityEngine;
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

	public SpawnInfo WindowInfo;

	public SpawnInfo PaintInfo;

	public SpawnInfo WeedInfo;

	public SpawnInfo RacoonInfo;

	public float EndGameDistance = 56;

	public GameObject EndGameArt;


    private float bgWidth;
    private Transform bgParent;
    private Transform objParent;

	private void Awake()
	{
        bgWidth = Background.GetComponent<SpriteRenderer>().sprite.bounds.size.x;

        bgParent = transform.GetChild(0);
        objParent = transform.GetChild(1);


		for (var i = 0; i < 8; ++i)
		{
			Instantiate(Background, new Vector3( i * bgWidth, 0, 5), Quaternion.identity, bgParent);
		}

		Instantiate(EndGameArt, Vector3.right * 8 * bgWidth, Quaternion.identity, objParent);

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
				Instantiate(info.thingToSpawn, new Vector3(x, info.GetYVariance, 0), Quaternion.identity, objParent);
				x += info.GetXAddition;
			}
		}
	}
}