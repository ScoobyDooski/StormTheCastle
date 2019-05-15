using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestTrigger : Enemy {

    public void Selected()
    {
        playerStats.foundChests = true;
        Destroy(gameObject);
    }
}
