using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag.CompareTo("Player") == 0)
        {
            DataManager.Instance.score += 1;
            gameObject.SetActive(false);
        }
    }
}
