using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public Transform playerPos;
    public Vector3 offset;
    public float scrollSpeed = .10f;
    void LateUpdate()
    {
        Vector3 velocity = Vector3.zero;
        Vector3 newPos = playerPos.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, newPos, ref velocity, scrollSpeed * Time.deltaTime);
    }
}
