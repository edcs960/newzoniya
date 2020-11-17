using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] NumberImage;
    public Sprite[] Number;

    public Image TimeBar;

    private void Update()
    {
        int temp = DataManager.Instance.score / 1000;
        NumberImage[0].GetComponent<Image>().sprite = Number[temp];
        int temp2 = DataManager.Instance.score % 1000;
        temp2 = temp2 / 100;
        NumberImage[1].GetComponent<Image>().sprite = Number[temp2];
        int temp3 = DataManager.Instance.score % 100;
        temp3 = temp3 / 10;
        NumberImage[2].GetComponent<Image>().sprite = Number[temp3];
        int temp4 = DataManager.Instance.score % 10;
        NumberImage[3].GetComponent<Image>().sprite = Number[temp4];

        if(!DataManager.Instance.PlayerDie)
        {
            DataManager.Instance.playerTimeCurrent -= 1 * Time.deltaTime;
            TimeBar.fillAmount = DataManager.Instance.playerTimeCurrent / DataManager.Instance.playTimeMax;
            if (DataManager.Instance.playerTimeCurrent < 0)
            {
                DataManager.Instance.PlayerDie = true;
            }
        }
    }
}
