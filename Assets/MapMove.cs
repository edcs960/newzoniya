using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{
    public float mapSpeed;
    private void Update()
    {
        if(!DataManager.Instance.PlayerDie)
        {
            transform.Translate(-mapSpeed * 0, -Time.deltaTime, 0);
        }
    }
}