using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Manager GameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.CompleteLevel();
    }
}
