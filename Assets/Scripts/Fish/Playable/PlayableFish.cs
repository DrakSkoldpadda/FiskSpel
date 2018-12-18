using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class PlayableFish : MonoBehaviour
{
    [Header("Stats")]
    [Range(5f, 15f)]
    public float movementSpeed = 10f;
    public int HP = 10;
    
    public float scale = 1f;

    private Rigidbody2D rbody;

    void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);

        rbody.velocity = movement * movementSpeed;

        if (horizontal < 0)
        {
            transform.localScale = new Vector2(-scale, transform.localScale.y);
        }
        else if (horizontal > 0)
        {
            transform.localScale = new Vector2(scale, transform.localScale.y);
        }
    }
}
