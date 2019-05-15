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
            //FindObjectOfType<AudioManager>().Play("Sword1");
            enemy.Attacked();
            
        }
        
    }
    private void OnCollisionStay(Collision col)

    {
        
        if (col.collider.tag == "Chest")
        {
            ChestTrigger chest = col.gameObject.GetComponent<ChestTrigger>();
            if (OVRInput.GetDown(OVRInput.Button.One))
            {
                //FindObjectOfType<AudioManager>().Play("Chest");
                chest.Selected();

            }

        }
    }
    private void OnCollisionExit(Collision col)
    {
        //Debug.Log("Exit");
    }
}
