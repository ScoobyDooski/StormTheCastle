using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class CharacterStats : MonoBehaviour {

    public int maxHealth = 50;
    public int currentHealth { get; private set; }

    public Stat stamina;
    public Stat damage;
    public bool foundChests = false;
    [Header("Health Bar")]
    public Image healthbar;



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
