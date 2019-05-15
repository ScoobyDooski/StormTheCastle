using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour {

    public CharacterStats enemy;
    public PlayerManager pManager;
    public CharacterStats playerStats;
    public Enemy curEnemy;

    [Header ("Health Bar")]
    public Image healthbar;

    private void Start()
    {
        enemy = GetComponent<CharacterStats>();
        pManager = PlayerManager.instance;
        playerStats = pManager.player.GetComponent<CharacterStats>();

    }

    public void Attacked()
    {
        enemy.TakeDamage(playerStats.damage.GetStat());

        healthbar.fillAmount = (float)enemy.currentHealth / (float)enemy.maxHealth;
        Debug.Log(enemy.currentHealth);
        Debug.Log(enemy.maxHealth);
        Debug.Log((float)(enemy.currentHealth / enemy.maxHealth));
    }

}
