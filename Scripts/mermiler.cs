using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermiler : MonoBehaviour
{
    
    public Transform cephane,namlu;
    [SerializeField]
    private AudioSource sesKaynagi;
    [SerializeField]
    private AudioClip sesKlibi;
    
    void Start()
    {
        cephane = GameObject.FindGameObjectWithTag("Mermi").transform;  //mermi çağrılıyor.
        namlu = GameObject.FindGameObjectWithTag("Namlu").transform; //Tüfeğin namlusuna yerleştirdiğimiz nesneyi nitelendiriyor.
        sesKaynagi = this.GetComponent<AudioSource>();
       
    }
   

    // Update is called once per frame
    void Update()
    {
        Vector3 gorusAcisi = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float gorus = Mathf.Atan2(gorusAcisi.y,gorusAcisi.x) * Mathf.Rad2Deg;
        Quaternion donus = Quaternion.AngleAxis(gorus, Vector3.forward);
        transform.rotation = donus;
        if (Input.GetMouseButtonDown(0))
        {
            mermiUret();
        }
    }
    public void mermiUret()
    {
        if(cephane !=null)
        {
            
            Transform cephaneler = Instantiate(cephane, namlu.position, Quaternion.identity) as Transform;
           
                Destroy(cephaneler.gameObject, 10f);
                Debug.Log("Mermi üretimine başlandı");
            if(!sesKaynagi.isPlaying)
            {
                sesKaynagi.clip = sesKlibi;
                sesKaynagi.Play();
            }
                
            
        }
    }
}
