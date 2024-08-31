using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }
    
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.5f, 0, 0);
        }
       
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.5f, 0, 0);
        }

        float x = Mathf.Clamp(transform.position.x, -9.5f, 9.5f);

        transform.position = new Vector3(x, transform.position.y, transform.position.z);


    }



  
}



