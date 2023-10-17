using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderLogic : MonoBehaviour
{
    public float timer = 0;
    public float deadTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer == deadTime) {
            Destroy(gameObject);
        } else {
            timer++;
        }
    }
}
