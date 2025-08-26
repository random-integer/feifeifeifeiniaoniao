using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;

    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= spawnRate)
        {
            timer = 0;
            Instantiate(pipe, transform.position, transform.rotation);
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
