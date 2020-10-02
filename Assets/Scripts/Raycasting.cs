using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
    public float maxRayDistance = 25f;
    void FixedUpdate()
    {
        Ray ray = new Ray(transform.position, Vector3.left);
        RaycastHit[] hits = Physics.RaycastAll(ray, maxRayDistance);

        Debug.DrawLine(transform.position, transform.position + Vector3.left * maxRayDistance, Color.red);

        foreach (RaycastHit hit in hits)
        {
            Debug.Log(hit.transform.name);
        }
        
    }
}
