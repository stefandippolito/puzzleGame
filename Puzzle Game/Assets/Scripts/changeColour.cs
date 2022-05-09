using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColour : MonoBehaviour
{
    public Color myColor;
    
    private Renderer myRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        myRenderer = gameObject.GetComponent<Renderer>();
        if (other.gameObject.tag == "red")
        {
            Debug.Log("hit");

            // new Color(red,green,blue,a)
            
            myRenderer.material.color = new Color(1, 0, 0, 1);
            Destroy(other.gameObject);

        }
        
        else if (other.gameObject.tag == "green")
        {
            
            myRenderer.material.color = new Color(0, 1, 0, 1);
            Destroy(other.gameObject);
        }

        else if (other.gameObject.tag == "yellow")
        {
            myRenderer.material.color = new Color(1, 1, 0, 1);
            Destroy(other.gameObject);
        }

        else if (other.gameObject.tag == "pink")
        {
            myRenderer.material.color = new Color(1, 0, 1, 1);
            Destroy(other.gameObject);
        }

        else if (other.gameObject.tag == "lightBlue")
        {
            myRenderer.material.color = new Color(0, 1, 1, 1);
            Destroy(other.gameObject);
        }

        else if (other.gameObject.tag == "white")
        {
            myRenderer.material.color = new Color(1, 1, 1, 1);
            Destroy(other.gameObject);
        }




    }
}
