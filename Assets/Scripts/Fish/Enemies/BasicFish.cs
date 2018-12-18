using UnityEngine;

public class BasicFish : FishBase
{
    protected override void Start()
    {
        base.Start();

        moveSpeed = Random.Range(2f, 5f);
    }

    protected override void Move()
    {
        rBody.velocity = Vector2.right * moveSpeed;
    }
}
