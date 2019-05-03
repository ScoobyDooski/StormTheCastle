using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderDetector : MonoBehaviour {
    public CharacterStats player;
    public ChestTrigger chest;
    //public Enemy enemy;

    private void OnCollisionEnter(Collision col)
    {
        Enemy enemy = col.gameObject.GetComponent<Enemy>();
        if(col.collider.tag == "Enemy")
        {
            
            enemy.Attacked();
            
        }
        
    }
    private void OnCollisionStay(Collision col)
    {
        if (col.collider.tag == "Chest")
        {
            if (OVRInput.GetDown(OVRInput.Button.One))
            {
                Debug.Log("User is pressing A");
                chest.Selected();
                
                
            }

        }
    }
    private void OnCollisionExit(Collision col)
    {
        //Debug.Log("Exit");
    }
}
