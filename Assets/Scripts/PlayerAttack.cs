using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject attackPrefab;
    public Transform attackPoint;
    public float cooldown = 0.5f;

    private float lastAttackTime;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Attack();
        }
    }

    public void Attack()
    {
        if (Time.time - lastAttackTime < cooldown) return;
        if (attackPrefab == null || attackPoint == null) return;

        lastAttackTime = Time.time;

        GameObject atk = Instantiate(attackPrefab, attackPoint.position, Quaternion.identity);
        Destroy(atk, 0.3f);
    }
}