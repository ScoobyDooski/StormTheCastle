using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //pick a spawn location

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("TOUCHING!!!");
    }
}
