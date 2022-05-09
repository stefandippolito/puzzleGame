using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColour : MonoBehaviour
{
    
    //creates a variable for the renderer for the game object
    private Renderer myRenderer;
    
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        //assigns the renderer
        myRenderer = gameObject.GetComponent<Renderer>();
        if (other.gameObject.tag == "red")
        {

            // new Color(red,green,blue,a)
            // Gives the game object the colour red if other tag is red then destroys it

            myRenderer.material.color = new Color(1, 0, 0, 1);
            // Changes the rectangles tag to the colour it is
            gameObject.tag = "red";
            Destroy(other.gameObject);

        }
        
        else if (other.gameObject.tag == "green")
        {
            // Gives the game object the colour green if other tag is green then destroys it
            myRenderer.material.color = new Color(0, 1, 0, 1);

            // Changes the rectangles tag to the colour it is
            gameObject.tag = "green";

            Destroy(other.gameObject);
        }

        else if (other.gameObject.tag == "yellow")
        {
            // Gives the game object the colour yellow if other tag is yellow then destroys it
            myRenderer.material.color = new Color(1, 1, 0, 1);

            // Changes the rectangles tag to the colour it is
            gameObject.tag = "yellow";

            Destroy(other.gameObject);
        }

        else if (other.gameObject.tag == "pink")
        {
            // Gives the game object the colour pink if other tag is pink then destroys it
            myRenderer.material.color = new Color(1, 0, 1, 1);

            // Changes the rectangles tag to the colour it is
            gameObject.tag = "pink";

            Destroy(other.gameObject);
        }

        else if (other.gameObject.tag == "lightBlue")
        {
            // Gives the game object the colour light blue if other tag is lightBlue then destroys it
            myRenderer.material.color = new Color(0, 1, 1, 1);

            // Changes the rectangles tag to the colour it is
            gameObject.tag = "lightBlue";

            Destroy(other.gameObject);
        }

        else if (other.gameObject.tag == "white")
        {
            // Gives the game object the colour white if other tag is white then destroys it
            myRenderer.material.color = new Color(1, 1, 1, 1);

            // Changes the rectangles tag to the colour it is
            gameObject.tag = "white";

            Destroy(other.gameObject);
        }




    }
}
