using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyMovementScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed = 5;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 newPos = transform.position + new Vector3(horizontalInput * moveSpeed * Time.deltaTime, 0, 0);
        if(newPos.x < 1.60 && newPos.x > -1.85) {
            transform.position = newPos;
        }
    }
}
