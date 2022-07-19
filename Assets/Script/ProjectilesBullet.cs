
using UnityEngine;

public class ProjectilesBullet : MonoBehaviour
{
    [SerializeField]
    private float SpeedBullet = 7f;
    void Update()
    {
        transform.position += -transform.right * Time.deltaTime * SpeedBullet;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
