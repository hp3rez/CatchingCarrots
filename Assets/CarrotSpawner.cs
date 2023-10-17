using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotSpawner : MonoBehaviour
{

    public GameObject carrot;
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
        } else {
            spawn();
            timer = 0;
        }
    }

    void spawn() {
        float maxRight = transform.position.x + xOffset;
        float maxLeft = transform.position.x - xOffset;

        Instantiate(carrot, new Vector3(Random.Range(maxLeft, maxRight), 1.75f, 0), transform.rotation);
    }
}
