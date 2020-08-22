using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimalKillPlayer : MonoBehaviour
{
    public GameObject[] healthBars;
    private GameObject followBar;
    public Vector3 healthOffset;
    public int hunger;
    

    // Start is called before the first frame update
    void Start()
    {
        healthOffset = new Vector3(0, 0, 3);
        followBar = Instantiate(healthBars[hunger], (transform.position + healthOffset), healthBars[hunger].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        followBar.transform.position = (transform.position + healthOffset);
        
    }
    // Check if colliding with player. If so, destroy both and Game Over.
    public void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.name.Equals("Player"))
        {
            
           
            GameController.lives--;
            

            if (GameController.lives <= 0)
            {
                
                Destroy(other.gameObject);
            }

            Destroy(followBar);
            Destroy(gameObject);
        }

        if (other.gameObject.name.Contains("Carrot"))
        {

            
            Destroy(other.gameObject);
            hunger--;
            Destroy(followBar);
            if (hunger >= 1)
            {
                followBar = Instantiate(healthBars[hunger], (transform.position + healthOffset), healthBars[hunger].transform.rotation);
            }


            if (hunger <= 0)
            {
                GameController.score++;
                Destroy(gameObject);
            }
        }

        
        
    }
}
