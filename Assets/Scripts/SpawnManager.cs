using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    public List<Vector3> spawnPositions = new List<Vector3>();
    
    // Start is called before the first frame update
    void Start()
    {
        spawnPositions.Add(new Vector3(7f, 1.5f, 11f));
        spawnPositions.Add(new Vector3(5f, 1.5f, 10f));
        InvokeRepeating("Spawn", 5f, 5f);
    }

    void Spawn()
    {
        Instantiate(coinPrefab, spawnPositions[Random.Range(0, spawnPositions.Count)], Quaternion.identity);
        if (!GameManager.Instance.playerAlive)
        {
            CancelInvoke("Spawn");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
