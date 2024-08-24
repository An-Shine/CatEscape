using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArroyGenerator : MonoBehaviour
{

    public GameObject arrowPrefab;
    float spawnTime = 1.0f;
    float delta = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
            if(this.delta > this.spawnTime)
        {
            this.delta = 0f;
            GameObject arrow = Instantiate(arrowPrefab);
            int randX = Random.Range(-6, 7);
            arrow.transform.position = new Vector3(randX, 7, 0);

        }

    }
}
