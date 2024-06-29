using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    float timer = 0;
    public float heightOffset = 5;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe() {
        float max_height = transform.position.y + heightOffset;
        float min_height = transform.position.y - heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(min_height,max_height), 0), transform.rotation);
    }
}
