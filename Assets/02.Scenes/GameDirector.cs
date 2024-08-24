using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    public GameObject gameOverText;
    
    void Start()
    {
        hpGauge = GameObject.Find("HpGauge");
        
    }

    // Update is called once per frame
    public void DecreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        if (hpGauge.GetComponent<Image>().fillAmount<=0)
        {
            gameOverText.SetActive(true);
        }
    }
}
