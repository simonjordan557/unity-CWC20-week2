using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate random ball type at spawn position
        Instantiate(ballPrefabs[Random.Range(0,3)], spawnPos, ballPrefabs[0].transform.rotation);

        //Invoke this function again after a random delay
        startDelay = Random.Range(1.0f, 5.0f);
        Invoke("SpawnRandomBall", startDelay);
    }

}
