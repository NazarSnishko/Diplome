using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropeItem : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            bag.Instance.AddMood(1);
            Destroy(gameObject);
        }
    }
    
}
