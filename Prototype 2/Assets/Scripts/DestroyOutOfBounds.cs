using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float bound = 30.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   // Destroy projectile / animal as it goes off-screen
        if ((transform.position.z > bound) || (transform.position.z < -bound) || (transform.position.x > bound) || (transform.position.x < -bound))
        {
            Destroy(gameObject);
        }

        
    }
}
