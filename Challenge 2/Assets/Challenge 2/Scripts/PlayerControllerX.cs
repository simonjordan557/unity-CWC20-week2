using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    bool canFire = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if ((Input.GetKeyDown(KeyCode.Space)) && (canFire == true))
        
            
        {
            StartCoroutine(FireDog());        
        }
        
    }

    IEnumerator FireDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        canFire = false;
        yield return new WaitForSecondsRealtime(1);
        canFire = true;
    }
}
