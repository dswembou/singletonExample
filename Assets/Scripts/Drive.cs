using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ECM.Components;

public class Drive : MonoBehaviour
{
    [SerializeField] private float speed;
    void FixedUpdate()
    {
        if (GameManager.Instance.playerAlive)
        {
            transform.Translate(Vector3.forward * speed);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
