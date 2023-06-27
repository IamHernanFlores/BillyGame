using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDetection : MonoBehaviour
{
    public float raycastDistance = 1f;

    private void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;

        if (Physics.Raycast(transform.position, forward, out hit, raycastDistance))
        {
            GameObject obstacle = hit.collider.gameObject;
            Debug.Log("Colisión con obstáculo: " + obstacle.name);
        }
    }
}