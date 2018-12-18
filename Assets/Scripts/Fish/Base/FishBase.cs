using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
public abstract class FishBase : MonoBehaviour
{
    public float moveSpeed = 2f;

    protected SpriteRenderer rend;
    protected Color tint = Color.white;
    protected Rigidbody2D rBody;

    protected virtual void Awake()
    {
        rend = GetComponent<SpriteRenderer>();
        rBody = GetComponent<Rigidbody2D>();
    }

    protected virtual void Start()
    {
        ApplyTint();
    }

    protected virtual void ApplyTint()
    {
        RandomizeTint();
        rend.color = tint;
    }

    protected virtual void RandomizeTint()
    {
        tint = Random.ColorHSV(0f, 1f, 0.77f, 1f, 0.8f, 1f, 1, 1);
    }

    protected abstract void Move();

    protected virtual void Update()
    {
        Move();
    }

    protected virtual void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    protected virtual void OnTriggerEnter2D(Collider2D col)
    {

    }
}
