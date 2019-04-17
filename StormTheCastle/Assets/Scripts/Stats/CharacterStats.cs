using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterStats : MonoBehaviour {

    [SerializeField]
    private int value;

    public int GetVal()
    {
        return value;
    }
    
}
