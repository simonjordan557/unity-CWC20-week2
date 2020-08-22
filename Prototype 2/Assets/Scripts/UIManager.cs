using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    
    public Text scoreText;
    public Text livesText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + GameController.score;
        livesText.text = "Lives: " + GameController.lives;

        if (GameController.lives <= 0)
        {
            scoreText.text = "GAME OVER! YOU SCORED " + GameController.score;
        }
               
    }
}
