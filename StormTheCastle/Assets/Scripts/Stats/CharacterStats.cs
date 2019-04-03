using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {


    public int maxHealth = 100;
    public int currentHealth { get; private set;  }
    
    public Stat stamina;
    public Stat damage;
    public bool foundChest;
    
}
