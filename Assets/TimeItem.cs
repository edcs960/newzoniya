﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (!DataManager.Instance.PlayerDie)
        {
            if(coll.gameObject.tag.CompareTo("Player") == 0)
            {
                DataManager.Instance.playerTimeCurrent += 3f;
                if (DataManager.Instance.playerTimeCurrent > DataManager.Instance.playTimeMax)
                {
                    DataManager.Instance.playerTimeCurrent = DataManager.Instance.playTimeMax;
                }
                gameObject.SetActive(false);
            }
        }
    }
}
