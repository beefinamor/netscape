using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float minX, maxX;
    public float timelerp;

    private void FixedUpdate()
    {
        Vector3 newPosition = player.position + new Vector3(0,2,-10);
        newPosition.y = 2.0f;
        newPosition = Vector3.Lerp(transform.position, newPosition, timelerp);

        transform.position = newPosition;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y, transform.position.z);
    }
}
