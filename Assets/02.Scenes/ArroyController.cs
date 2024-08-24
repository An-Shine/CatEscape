using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArroyController : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = GameObject.Find("player");
    }


    void Update()
    {

        transform.Translate(0, -0.1f, 0);

        if (transform.position.y < -5.0f)
        {
            Destroy(this.gameObject);

        }

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
