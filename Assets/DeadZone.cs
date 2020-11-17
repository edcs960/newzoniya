using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(!DataManager.Instance.PlayerDie)
        {
            if(coll.gameObject.tag.CompareTo("Player") == 0)
            {
                DataManager.Instance.PlayerDie = true;
            }
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
