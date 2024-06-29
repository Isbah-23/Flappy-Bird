using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float move_speed = 50;
    public float dead_zone = -45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * move_speed) * Time.deltaTime;
        if (transform.position.x < dead_zone)
            Destroy(gameObject);
    }
}
