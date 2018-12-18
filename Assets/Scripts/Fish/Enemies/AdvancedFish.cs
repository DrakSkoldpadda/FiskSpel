using UnityEngine;

public class AdvancedFish : BasicFish
{
    public float upDownMultiplier = 0.1f;

    protected override void Start()
    {
        base.Start();

        moveSpeed += 0.7f;
        upDownMultiplier = Random.Range(0.1f, 0.3f);
    }

    protected override void Move()
    {
        rBody.velocity = Vector2.right * moveSpeed + Vector2.up * Mathf.Sin(Time.time * 1 / upDownMultiplier) * moveSpeed;
    }
}
