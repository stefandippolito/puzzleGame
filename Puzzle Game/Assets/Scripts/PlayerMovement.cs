using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if player presses R rotate 90 degreese on the z
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.Rotate(0, 0, 90);
        }

        //since the players position rotates aound the z axis I can't just do Vector3.right to move it forward, I did 4 if cases for each rotate senero so the 
        //cube is always moving forward on he screan.
        if (transform.rotation.eulerAngles.z == 0)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        else if (transform.rotation.eulerAngles.z == 90)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        else if (transform.rotation.eulerAngles.z == 180)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        else
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }




    }
}
