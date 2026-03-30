using UnityEngine;

public class AttackHitbox : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Boss"))
        {
            other.GetComponent<Boss>().TakeDamage();
        }
    }
}