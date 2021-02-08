using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tufekDonusu : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        donme();
    }
    public void donme()
    {
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown("right"))
        {
            transform.rotation = Quaternion.Euler(new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, (transform.eulerAngles.z +90f)));
            Debug.Log("Sağa doğru dönüş sağlanacak");
        }
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown("left"))
        {
            transform.rotation = Quaternion.Euler(new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, (transform.eulerAngles.z-90f)));
            Debug.Log("Sola doğru dönüş sağlanacak");
        }
    }
}
