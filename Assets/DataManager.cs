﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    static DataManager instance;
    public float playerTimeCurrent = 10f;
    public float playTimeMax = 10f;
    public bool PlayerDie = false;

    public static DataManager Instance 
    {
        get 
        {
            return instance;
        }
    }

    private void Awake() 
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else 
        {
            DestroyObject(gameObject);
        }
    }

    public int score = 0;
}