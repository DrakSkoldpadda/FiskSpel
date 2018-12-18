using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject[] fishPrefabs;

    public float spawnCoolDown = 2f;
    private float coolDown;

    // Update is called once per frame
    void Update()
    {
        int selectedIndex = Random.Range(0, fishPrefabs.Length);

        float randomPositon = Random.Range(-3f, 3f);

        Vector2 spawnPostion = new Vector2(-9, randomPositon);

        coolDown -= Time.deltaTime;

        if (coolDown <= 0)
        {
            Instantiate(fishPrefabs[selectedIndex], spawnPostion, Quaternion.identity);
            coolDown = spawnCoolDown;
        }
    }
}
