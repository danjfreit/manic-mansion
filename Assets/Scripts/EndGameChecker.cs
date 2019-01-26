using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LinearMove))]
public class EndGameChecker : MonoBehaviour
{
    private LinearMove _cameraMove;
    private Transform _transform;

    public float EndGameDistance;
    public PlayerMove PlayerMove;
    public GameObject EndGamePopup;
    
    private void Awake()
    {
        _cameraMove = GetComponent<LinearMove>();
        _transform = transform;
    }

    private void Update()
    {
        if (_transform.position.x >= EndGameDistance)
        {
            _cameraMove.enabled = false;
            if (PlayerMove != null)
            {
                PlayerMove.enabled = false;
            }

            Instantiate(EndGamePopup);
            Destroy(this);
        }
    }
}
