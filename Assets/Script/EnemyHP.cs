using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int enemyHP;
    private int currentHP;
    void Start()
    {
        enemyHP = 1;
    }

    void Update()
    {
      
        if (enemyHP<=0) {
            Destroy(transform.parent.gameObject);
        }
    }
    public void TakeDamage(int damage) {
        enemyHP -= damage;

    }
}
