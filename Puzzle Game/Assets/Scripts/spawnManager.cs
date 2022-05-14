using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class spawnManager : MonoBehaviour
{
    /* The thought process behing this is that since there are only 4 edges of the players cube but 6 enemy colours, there shold not be an instance where
     * there is an enemy where it is imposible for the player to of killed.  For example if the first circle was red, then, green, then pink, the player should not see
     * a light blue enemy becuase it would have been imposible for them to have a light blue edge.  This is where the history list queue comes into play. I chose a list
     * instead of a linked list or array becuase lists are dinamicaly alocated and it is easier to chose a random element in a list then a linked list. The list is at max 4
     * elements long becuase the player has 4 edges. It starts with only white becuase the player starts with all white edges.  It then adds the enemy of the colour of the
     * circle that is randomly chosen to the front of the queue.  For example if the first circle chosen is the pink one, then in the history list will be [pinkEnemy,whiteEnemy].
     * When the list gets to 5 elements long, I remove the last enemy element from the list.  This is what creates the first in first out of the queue.  The reason I remove
     * the last one is due to the stragity of the game.  The game is simple but can get complex when thought about in depth. The stragity of the game is to always remove the
     * edge that has been there the longest, and also if a circle comes up and you have that colour, make sure you hit it with the edge of the same colour. For example if you have
     * white,red,pink, and yellow edges and a red circle comes, make sure it comes into contact with the red edge becuase removing say a whit and having two red edges can put
     * the player in danger of not having the colour of an enemy.
     */

    // arrays for he circle prefab and enemy prefab
    public GameObject[] colourCirclePrefabs;
    public GameObject[] enemyPrefabs;

    //Using a list so I can dinamicaly add and remove elements in the list for the history queue.
    public List<GameObject> history = new List<GameObject>();
    public GameObject player;
    private int arrayMax = 5;
    
    
    private bool circOrRec = true;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandom",1,3);
    }

    
    void SpawnRandom()
    {
        int randomNum = Random.Range(0, colourCirclePrefabs.Length);

        // if circOrRec is true then spawn a circle, if not then spawn a rectangle/enemy
        if (circOrRec)
        {
            Instantiate(colourCirclePrefabs[randomNum], new Vector2(player.transform.position.x + 26, 0.01f), colourCirclePrefabs[randomNum].transform.rotation);
            rearrangeHistory(randomNum);
            circOrRec = false;
        }
        else
        {
            int randomEnemy = Random.Range(0, history.Count);
            Instantiate(history[randomEnemy], new Vector2(player.transform.position.x + 26, .79f), history[randomEnemy].transform.rotation);
            circOrRec = true;
        }
    }

    void rearrangeHistory(int randomNum)
    {

        if (!history.Contains(enemyPrefabs[randomNum]))
        {
            history.Insert(0, enemyPrefabs[randomNum]);
        }

        if (history.Count == arrayMax)
        {
            history.Remove(history[arrayMax-1]);
        }

    }
}
