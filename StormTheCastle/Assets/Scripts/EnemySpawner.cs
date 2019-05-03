using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public Transform enemy;
    public int difficulty;
    

    public Transform[] spawnPoints;
  

    private void Start()
    {
       for (int i = 0; i < spawnPoints.Length; i++)
       {
           Transform sp = spawnPoints[i];
           Instantiate(enemy, sp.position, sp.rotation);
       } 
    }

    
}
