using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    public GameObject gameOverText;
    public Text playTimeText;
    float delta = 0f;

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



    void Update()
    {
        this.delta += Time.deltaTime;
        playTimeText.text = delta.ToString("F2") + "sec";
    }



    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}



