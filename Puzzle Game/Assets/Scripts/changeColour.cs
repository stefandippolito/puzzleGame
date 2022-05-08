using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColour : MonoBehaviour
{
    private Color myColor;
    private Renderer myRenderer;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit");
        if(other.gameObject.tag == "red")
        {
            // new Color(red,green,blue,a)
            myColor = new Color(1, 0, 0, 1);
            myRenderer.material.color = myColor;
            Destroy(other);
        }
    }
}
