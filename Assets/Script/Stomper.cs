using System.Collections;
using System.Collections.Generic;
using UnityEngine;  

public class Stomper : MonoBehaviour
{
    public int damageTodeal ;
    private Rigidbody2D rb;
    public float BounceForce;
    void Start()
    {
        rb = transform.parent.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hurtbox")
        {
            collision.gameObject.GetComponent<EnemyHP>().TakeDamage(damageTodeal);
            rb.AddForce(transform.parent.up * BounceForce, ForceMode2D.Impulse);
        }
    }
}
