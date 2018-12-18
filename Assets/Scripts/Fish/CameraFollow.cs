using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    public float followSpeed;

    void Awake()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = followSpeed * Time.deltaTime;
        Vector2 playerPosition = new Vector2(player.position.x, player.position.y);
        Vector3 currentPosition = new Vector3(transform.position.x, transform.position.y, -10);

        transform.position = Vector3.MoveTowards(currentPosition, playerPosition, speed);
    }
}
