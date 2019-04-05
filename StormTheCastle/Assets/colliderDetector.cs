using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderDetector : MonoBehaviour {

    private void OnCollisionEnter(Collision col)
    {
        Debug.Log("Entered");
    }
    private void OnCollisionStay(Collision col)
    {
        Debug.Log("Stay");
    }
    private void OnCollisionExit(Collision col)
    {
        Debug.Log("Exit");
    }
}
