using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnrate = 2;
    private float timer = 0;
    public float height = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
        }
    }

    void spawnpipe()
    {
        float lowestpoint = transform.position.y - height;
        float highestpoint = transform.position.y + height;
        Instantiate(
            Pipe,
            new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0),
            transform.rotation
        );
    }
}
