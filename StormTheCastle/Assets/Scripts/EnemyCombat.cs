using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterStats))]
public class EnemyCombat : MonoBehaviour {

    CharacterStats player;
    public float attackSpeed = 1f;
    private float cooldown = 0f;


    private void Update()
    {
        cooldown -= Time.deltaTime;
    }

    private void Start()
    {
        player = GetComponent<CharacterStats>();
    }


    public void Attack (CharacterStats targetStats)
    {
        Debug.Log("Attack was called before cooldown");
        if (cooldown <= 0f)
        {
            Debug.Log("Attack was called before takedamage");
            targetStats.TakeDamage(player.damage.GetStat());
        }
        
    }
}
