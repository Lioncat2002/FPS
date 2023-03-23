using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var spawnPoint in spawnPoints)
            Instantiate(enemy,spawnPoint.transform.position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
