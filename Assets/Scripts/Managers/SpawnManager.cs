using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemySpawnPoints;
    public GameObject[] victimSpawnPoints;
    public GameObject enemy;
    public GameObject victim;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var spawnPoint in enemySpawnPoints)
            Instantiate(enemy,spawnPoint.transform.position,Quaternion.identity);
        foreach (var spawnPoint in victimSpawnPoints)
            Instantiate (victim,spawnPoint.transform.position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
