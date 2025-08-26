using UnityEngine;
using UnityEngine.Serialization;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    [FormerlySerializedAs("spawnRate")] public float spawnrate = 2;

    private float timer = 0;

    public float heightOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= spawnrate)
        {
            timer = 0;
            SpawnPipe();
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}