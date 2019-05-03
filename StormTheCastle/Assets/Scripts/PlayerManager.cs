using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    #region Singleton

    public static PlayerManager instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject player;


    public void Update() {
        if (player.transform.position.y < -5)
        {
            player.transform.position = new Vector3(0, 3, 14);
        }

        

    }

}   
