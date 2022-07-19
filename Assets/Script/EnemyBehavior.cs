using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour

{
    public Rigidbody2D rb;
   
    [SerializeField]
    private float moveSpeed = 6f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (IsFacingRight()) {
            rb.velocity = new Vector2(moveSpeed,0f);
        } else {
            rb.velocity = new Vector2(-moveSpeed, 0f);
        }

    }
    private bool IsFacingRight() {
        return transform.localScale.x > Mathf.Epsilon;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
    }
 
}
