using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hedefeDogru : MonoBehaviour
{
    [SerializeField]
    private Transform tufek;
    [SerializeField]
    private mermiler mermi;
    [SerializeField]
    private Rigidbody2D sa;

    
    void Start()
    {
        tufek = GameObject.FindGameObjectWithTag("Tüfek").transform;
        mermi = tufek.GetComponent<mermiler>();
        sa = this.GetComponent<Rigidbody2D>();
       
    }

    
    void Update()
    {
        gorusAcisi();
    }

    public void gorusAcisi()
    {
        Physics2D.IgnoreCollision(this.GetComponent<BoxCollider2D>(),tufek.GetComponent<BoxCollider2D>());
        sa.AddForce(-transform.right*5f,ForceMode2D.Force);
        Vector3 aci = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float acidonusu = Mathf.Atan2(aci.y, aci.x) * Mathf.Rad2Deg;
        Quaternion eksendonusu = Quaternion.AngleAxis(acidonusu,Vector3.forward);
        transform.rotation = eksendonusu;
          
    }
}