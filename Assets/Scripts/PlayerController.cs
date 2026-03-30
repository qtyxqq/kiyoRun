using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float runSpeed = 4f;
    public float jumpForce = 12f;
    public float highJumpForce = 18f;
    public float gravity = -30f;
    public float groundY = -3f;

    public int maxHP = 3;
    private int currentHP;

    private float velocityY;
    private int jumpCount = 0;
    private float pressTime;

    void Start()
    {
        currentHP = maxHP;
    }

    void Update()
    {
        AutoRun();
        ApplyGravity();
        HandleInput();
    }

    void AutoRun()
    {
        transform.position += Vector3.right * runSpeed * Time.deltaTime;
    }

    void ApplyGravity()
    {
        velocityY += gravity * Time.deltaTime;
        transform.position += new Vector3(0, velocityY * Time.deltaTime, 0);

        if (transform.position.y <= groundY)
        {
            transform.position = new Vector3(transform.position.x, groundY, transform.position.z);
            velocityY = 0;
            jumpCount = 0;
        }
    }

    void HandleInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject()) return;
            pressTime = Time.time;
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject()) return;

            float holdTime = Time.time - pressTime;

            if (jumpCount < 2)
            {
                float force = holdTime > 0.3f ? highJumpForce : jumpForce;
                Jump(force);
                jumpCount++;
            }
        }
    }

    void Jump(float force)
    {
        velocityY = force;
    }

    public void TakeDamage()
    {
        currentHP--;
        if (currentHP <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}