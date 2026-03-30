using UnityEngine;

public class Boss : MonoBehaviour
{
    public int hp = 10;
    public float speed = 2f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void TakeDamage()
    {
        hp--;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}