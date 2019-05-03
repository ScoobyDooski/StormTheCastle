﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIEnemyController : MonoBehaviour {
    [SerializeField]
    public float senseRadius = 5f;

    Transform target;
    NavMeshAgent agent;
    EnemyCombat combat;

	// Use this for initialization
	void Start () {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        combat = GetComponent<EnemyCombat>();
	}
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= senseRadius)
        {
            agent.SetDestination(target.position);

            if (distance <= agent.stoppingDistance)
            {
                //face and attack target       
                //combat.Attack();
                //Debug.Log("ENEMY ATTACKED THE PLAYER");
                
               
                FaceTarget();
            }
        }
	}
    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
       
    } 

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, senseRadius);
    }
}
