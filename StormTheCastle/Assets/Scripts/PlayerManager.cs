using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerManager : MonoBehaviour {

    #region Singleton

    public static PlayerManager instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject player;
    //CharacterStats playerStats = instance.player.GetComponent<CharacterStats>();
    CharacterStats playerStats;
   

    public void Start()
    {
        playerStats = player.GetComponent<CharacterStats>();
    }

    public void Update() {
        if (player.transform.position.y < -5)
        {
            player.transform.position = new Vector3(0, 3, 14);
        }        
        if(playerStats.currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            //you lose
            //play sound

        }
        if(playerStats.foundChests == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            //you win
            //play sound
        }

    }

   

}   
