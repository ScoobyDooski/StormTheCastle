using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderDetector : MonoBehaviour {
    public EnemyStats enemy;
    public PlayerStats player;

    private void OnCollisionEnter(Collision col)
    {
        if(col.collider.name == "Enemy")
        {
            Debug.Log("User has hit the enemy");
            enemy.TakeDamage(player.damage);
        }
    }
    private void OnCollisionStay(Collision col)
    {
        //Debug.Log("Stay");
    }
    private void OnCollisionExit(Collision col)
    {
        //Debug.Log("Exit");
    }
}
