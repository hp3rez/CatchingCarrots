using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < -1) {
            Destroy(gameObject);
        }
    }
}
