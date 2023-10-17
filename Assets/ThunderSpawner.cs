using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderSpawner : MonoBehaviour
{

    public GameObject cloud;
    public GameObject lightning;
    public float spawnRate = 4;
    public float timer = 0;
    public float xOffset = 2;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate) {
            timer++;
            destroy();
        } else {
            spawn();
            timer = 0;
        }
    }

    void spawn() {
        float maxRight = transform.position.x + xOffset;
        float maxLeft = transform.position.x - xOffset;
        float xVal = Random.Range(maxLeft, maxRight);

        Instantiate(cloud, new Vector3(xVal, 1.25f, 0), transform.rotation);
        Instantiate(lightning, new Vector3(xVal, 1.15f, 0), transform.rotation);
    }

    void destroy() {
        if(timer == 10) {
            GameObject.Destroy(cloud);
        }
    }
}
