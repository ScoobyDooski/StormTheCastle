using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSpawner : MonoBehaviour {

    public Transform chest;
    public int difficulty;


    public Transform[] spawnPoints;

    private void Start()
    {
        int i = spawnPoints.Length;
        int randomSpawn = Random.Range(0, i);
        Transform sp = spawnPoints[randomSpawn];
        Instantiate(chest, sp.position, sp.rotation);
        
    }
}
