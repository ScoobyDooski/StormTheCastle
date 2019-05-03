using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour {

    public CharacterStats enemy;
    public PlayerManager pManager;
    public CharacterStats playerStats;

    private void Start()
    {
        enemy = GetComponent<CharacterStats>();
        pManager = PlayerManager.instance;
        playerStats = pManager.player.GetComponent<CharacterStats>();

    }

    public void Attacked()
    {
        Debug.Log("Attacked called");
        enemy.TakeDamage(playerStats.damage.GetStat());
    }


}
