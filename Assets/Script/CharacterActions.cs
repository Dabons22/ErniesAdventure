using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterActions : MonoBehaviour
{
    [SerializeField]    
    private Transform Player;
    void Update()
    {
        if (Player.transform.position.y<-9f) {
            Debug.Log("You Lose");
            FindObjectOfType<Manager>().Endgame();
        }    
    }
}
