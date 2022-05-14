using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
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
    }
}
