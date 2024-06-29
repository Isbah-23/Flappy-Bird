using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject Cloud;
    public float spawn_rate_cloud = 2f;
    float timer = 0;
    public float height_offset = 1000;
    // Start is called before the first frame update
    void Start()
    {
        SpawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawn_rate_cloud)
            timer += Time.deltaTime;
        else {
            SpawnCloud();
            timer = 0;
        }
    }
    void SpawnCloud() {
        float max_height = transform.position.y + height_offset;
        float min_height = transform.position.y - height_offset;
        GameObject newly_spawned_cloud = Instantiate(Cloud, new Vector3(40, Random.Range(min_height, max_height), 2), transform.rotation);
        float scale_offset = Random.Range(1, 4);
        newly_spawned_cloud.transform.localScale = new Vector3(scale_offset, scale_offset, scale_offset);
    }
}
