using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	private Transform _transform;

	public float Speed;

	// Start is called before the first frame update
	private void Awake()
	{
		_transform = transform;
	}

	// Update is called once per frame
	private void Update()
	{
		var dir = Input.GetAxis("Vertical") * Vector3.up * Speed * Time.deltaTime;
		_transform.Translate(dir);
	}
}