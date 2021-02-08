using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dokunus : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.transform.tag=="Sikke")
        {
            Destroy(collision.gameObject);
        }
    }
}
