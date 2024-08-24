using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArroyController : MonoBehaviour
{
    
    void Start()
    {
        
    }
    public GameObject player;

    void Update()
    {
        Vector2 p1 = this.transform.position;
        Vector2 p2 = player.transform.position;

        Vector2 dir = p1 - p2;
        float d = dir.magnitude;

        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {

            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent < GameDirector>().DecreaseHp();

            Destroy(this.gameObject);
        }
    
    }
}
