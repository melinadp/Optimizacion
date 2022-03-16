using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    public float timeSpawn = 3f, RangeSpawn = 20f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0.0f, timeSpawn);
    }

    public void Spawn()
    {
        Vector3 SpawnPosition = new Vector3 (0, 0, 0);
        SpawnPosition = this.transform.position + Random.onUnitSphere * RangeSpawn;
        SpawnPosition = new Vector3 (SpawnPosition.x, 22, SpawnPosition.z);

        GameObject AlienFighter = PoolManager.instance.GetPooledObject(1);
        AlienFighter.transform.position = SpawnPosition;
        AlienFighter.SetActive (true);
    }
}
