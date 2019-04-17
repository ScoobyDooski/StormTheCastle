using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public int maxHealth = 100;
    public int currentHealth { get; private set; }

    public Stat stamina;
    public int damage = 5;
    public bool foundChest;


    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");

        if (currentHealth <= 0)
        {
            Death();
        }
    }

    public virtual void Death()
    {
        Debug.Log(transform.name + " died.");
    }
}
