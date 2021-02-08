using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraKonumu : MonoBehaviour
{
    [SerializeField]
    private Transform ileri;
    public Vector3 anlikKonum;
    void Start()
    {
        ileri = GameObject.FindGameObjectWithTag("Tüfek").transform;
        anlikKonum = transform.position;

    }

   
    void Update()
    {
        Vector3 beklenenKonum = anlikKonum + ileri.position;
        transform.position = Vector3.MoveTowards(transform.position,beklenenKonum,3f*Time.deltaTime);
    }
}
