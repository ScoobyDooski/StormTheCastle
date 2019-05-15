using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterStats))]
public class EnemyCombat : MonoBehaviour {

    CharacterStats playerStats;
    CharacterStats enemy;
    public float attackSpeed = 1f;
    private float cooldown = 0f;
    PlayerManager pManager;
    public bool inCombat;

    public event System.Action OnAttack;


    void Update()
    {
        cooldown -= Time.deltaTime;
    }

    void Start()
    {
        pManager = PlayerManager.instance;
        playerStats = pManager.player.GetComponent<CharacterStats>();
        enemy = GetComponent<CharacterStats>();
        
        
    }


    public void Attack ()
    {
        //Debug.Log("IN ATTACK");

        if (cooldown <= 0)
        {
            if(OnAttack!= null)
            {
                //FindObjectOfType<AudioManager>().Play("punch1");
                OnAttack();
            }
            playerStats.TakeDamage(enemy.damage.GetStat());
            //Debug.Log("Player health: " + playerStats.currentHealth);
            cooldown = 2;
        }
    }
    
}
