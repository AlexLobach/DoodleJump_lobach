using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;

    [SerializeField] private float smoothSpeed = 5f;

    private Vector3 endPos;
    public bool canFollow;

    private void FixedUpdate()
    {
        if (!canFollow) return;
        if (transform.position.y >= endPos.y) return;
        transform.position = Vector3.Slerp(transform.position,endPos,smoothSpeed*Time.fixedDeltaTime);
    }

    public void UpdateCamera()
    {
        endPos = transform.position;
        endPos.y = target.position.y + 1.5f;
    }
}
