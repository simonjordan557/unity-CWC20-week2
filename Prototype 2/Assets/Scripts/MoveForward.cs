using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;
    private Vector3 velocity;
    

    // Start is called before the first frame update
    void Start()
    {
        velocity = Vector3.forward * speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity);
    }
}
