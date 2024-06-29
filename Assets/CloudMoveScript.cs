using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMoveScript : MonoBehaviour
{
    public float cloud_move_speed = 5;
    public float dead_zone_cloud = -45;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * cloud_move_speed) * Time.deltaTime;
        if (transform.position.x < dead_zone_cloud)
            Destroy(gameObject);
    }
}
