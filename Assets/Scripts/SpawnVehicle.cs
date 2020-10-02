using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVehicle : MonoBehaviour
{
    [SerializeField] private GameObject vehiclePrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2.5f, 2.5f);
    }

    void Spawn()
    {
        if (GameManager.Instance.playerAlive)
        {
            Instantiate(vehiclePrefab, transform.position, transform.rotation);
        }
        
    }
}
