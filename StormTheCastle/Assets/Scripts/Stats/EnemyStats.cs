using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : PlayerStats {

	public override void Death()
    {
        base.Death();

        Destroy(gameObject, 2f);
    }
}
