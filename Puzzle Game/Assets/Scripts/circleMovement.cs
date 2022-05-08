using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleMovement : MonoBehaviour
{
    public float speed = 2f;
    private float yPos;
    private float offset;

    //bool starts at true meaning the balls always start going up
    private bool up = true;

    // Start is called before the first frame update
    void Start()
    {
        // Get starting y position for to calculate offset
        yPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //find the difference in start to current y pos
        offset = transform.position.y - yPos;
        
        

        //if the ball hits an offset of 0.5 then make up changes to false
        if (offset >= .2)
        {
            up = false;
        }

        //if the ball hits an offset of -0.5 then up changes to true
        if (offset <= -.2)
        {
            up = true;
        }

        // if up is true, ball moves up
        if (up)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        // if up is false, ball moves down
        else
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        
    }
}
