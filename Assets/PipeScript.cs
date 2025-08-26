using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 5;

    public float leftmost = -20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(- moveSpeed * Time.deltaTime, 0, 0);
        if (transform.position.x < leftmost)
        {
            Destroy(gameObject);
        }
    }
}
