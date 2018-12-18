using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class DodgingFish : AdvancedFish
{
    public Collider2D canWalkCollider;

    protected enum DodgeState { NotDodging, Up, Down }

    protected DodgeState dodge = DodgeState.NotDodging;

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Move()
    {
        switch (dodge)
        {
            case DodgeState.NotDodging:
                base.Move();
                break;

            case DodgeState.Up:
                rBody.velocity = Vector2.up * moveSpeed;
                break;

            case DodgeState.Down:
                rBody.velocity = -Vector2.up * moveSpeed;
                break;
        }
    }

    void OnTriggerEnter2D()
    {
        //bounds.center tar från collision's collider center
        //transform.position tar från collision's mittpunkts center
        if (canWalkCollider.transform.position.y < transform.position.y)
        {
            dodge = DodgeState.Up;
        }
        else
        {
            dodge = DodgeState.Down;
        }
    }

    protected virtual void OnTriggerExit2d()
    {
        dodge = DodgeState.NotDodging;
    }
}
