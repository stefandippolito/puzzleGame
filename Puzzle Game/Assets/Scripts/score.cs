using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class score : MonoBehaviour
{
    // These enemyInteract scripts create a variable for every enemyInteract script(one for each rect in the player)
    public enemyInteract script1;
    public enemyInteract script2;
    public enemyInteract script3;
    public enemyInteract script4;
    private int playerScore;
    // Gets variable for text component
    public TextMeshProUGUI scoreText;
    public PlayerMovement speedScript;
    

    
    // Update is called once per frame
    void Update()
    {
        // Gets the score variable form each rectangle in the player and adds it togther to get the total score
        playerScore = script1.score + script2.score + script3.score + script4.score;
        
        // Changes the text component to show the score
        scoreText.SetText(playerScore.ToString());

        // every interval of 5 the players score goes up by the speed of the player increases by 3 units
        if (playerScore % 5 == 0 && (script1.hit || script2.hit || script3.hit || script4.hit))
        {
            speedScript.speed = speedScript.speed + 3f;

            // changes the hit bool in each rectangle to false so this is only changed once and not for every frame untill player score switches
            script1.hit = false;
            script2.hit = false;
            script3.hit = false;
            script4.hit = false;

        }


    }
}
