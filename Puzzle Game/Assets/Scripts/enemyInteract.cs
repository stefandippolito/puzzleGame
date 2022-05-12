using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enemyInteract : MonoBehaviour
{
    public int score = 0;
    private void OnCollisionEnter2D(Collision2D other)
    {
        //assigns the renderer
        
        // if colour of front rectange is the same as the enemey rectangle then destroy enemy rectangle and proceed with the level
        if ((other.gameObject.tag == "redEnemy" && gameObject.tag == "red") || (other.gameObject.tag == "greenEnemy" && gameObject.tag == "green") || 
            (other.gameObject.tag == "yellowEnemy" && gameObject.tag == "yellow") || (other.gameObject.tag == "pinkEnemy" && gameObject.tag == "pink") ||
            (other.gameObject.tag == "lightBlueEnemy" && gameObject.tag == "lightBlue") || (other.gameObject.tag == "whiteEnemy" && gameObject.tag == "white"))
        {

            Destroy(other.gameObject);
            score += 1;

        }
        //if front rectangle colides with an enemy and it s not the same colour then restart level
        else if (other.gameObject.tag == "redEnemy" || other.gameObject.tag == "greenEnemy" || other.gameObject.tag == "yellowEnemy" ||
            other.gameObject.tag == "pinkEnemy" || other.gameObject.tag == "lightBlueEnemy" || other.gameObject.tag == "whiteEnemy")
        {
            Application.LoadLevel(Application.loadedLevel);
        }

    }

}
