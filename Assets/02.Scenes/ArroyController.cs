using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArroyController : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(0, -0.1f, 0);
        if(transform.position.y < -5.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
