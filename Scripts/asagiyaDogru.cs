using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asagiyaDogru : MonoBehaviour
{


    [SerializeField]
    private Transform tufek;

    void Start()
    {
        tufek = GameObject.FindGameObjectWithTag("Tüfek").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.IgnoreCollision(this.GetComponent<CircleCollider2D>(),tufek.GetComponent<BoxCollider2D>());
        transform.position += Vector3.down * 3f * Time.deltaTime;
    }
}
