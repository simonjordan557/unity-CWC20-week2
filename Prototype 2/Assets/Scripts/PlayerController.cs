using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public string inputAxisVertical = "Vertical";
    public string inputAxisHorizontal = "Horizontal";
    private float speed = 15.0f;
    private float xRange = 16.0f;
    private float zRange = 9.0f;
    private Vector3 velocityX;
    private Vector3 velocityZ;

    public GameObject projectilePrefab;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move character left and right
        horizontalInput = Input.GetAxis(inputAxisHorizontal);
        velocityX = Vector3.right * speed * Time.deltaTime * horizontalInput;
        transform.Translate(velocityX);

        // Move character up and down
        verticalInput = Input.GetAxis(inputAxisVertical);
        velocityZ = Vector3.forward * speed * Time.deltaTime * verticalInput;
        transform.Translate(velocityZ);

        // Set left and right screen boundary
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Set top and bottom screen boundary
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        // Launch a projectile from the player
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

    
}

