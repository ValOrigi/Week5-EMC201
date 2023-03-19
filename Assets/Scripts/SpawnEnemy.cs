using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public bool cannotSpawn = false;
    public bool spawned = false;
    public GameObject enemyPrefab;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!cannotSpawn)
        {
            StartCoroutine(cooldown());
        }
    }

    void Spawn()
    {
        if(!spawned)
        {
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }

    IEnumerator cooldown()
    {
        cannotSpawn = true;
        spawned = false;
        yield return new WaitForSeconds(3);
        Spawn();
        spawned = false;
        cannotSpawn = true;
        StartCoroutine(cooldown());
    }
}
