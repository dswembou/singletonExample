using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swim : MonoBehaviour
{
    [SerializeField] private float speed;

    void Start()
    {
        InvokeRepeating("Turn", 2.5f, 5f);
    }

    void Turn()
    {
        if (GameManager.Instance.playerAlive)
        {
            Vector3 scale = transform.localScale;
            if (scale.z >= 0.5f)
            {
                scale.z = -1f;
            }
            else
            {
                scale.z = 1f;
            }

            speed = -speed;
            transform.localScale = scale;
        }
        
    }
    void FixedUpdate()
    {
        if (GameManager.Instance.playerAlive)
        {
            transform.Translate(Vector3.forward * speed);
        }
        
    }
}
