using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paralarAsagi : MonoBehaviour
{
    [SerializeField]
    private float menzil;
    [SerializeField]
    private float surat;
    [SerializeField]
    private Transform madeni;
    [SerializeField]
    private float sure;
    [SerializeField]
    private Transform uretme;
    void Start()
    {
        madeni = GameObject.FindGameObjectWithTag("Sikke").transform;
        uretme = GameObject.FindGameObjectWithTag("Üretici").transform;
        menzil = Random.Range(-9.68f,10.73f);
        sure = 0f;
        surat = 5f;
    }

    // Update is called once per frame
    void Update()
    {

        uretim();
        
    }
    public void uretim()
    {
        sure += Time.deltaTime;
        if(sure >=5f)
        {
            if(madeni !=null)
            {
                Transform sds = Instantiate(madeni, new Vector3(menzil, (uretme.position.y-1f), uretme.position.z),Quaternion.identity) as Transform;
                Rigidbody2D rigidbody2D = sds.GetComponent<Rigidbody2D>();
                rigidbody2D.AddForce(Vector3.down * 3f * Time.deltaTime);
                
                Destroy(sds.gameObject, 8f);
                sure = 0f;
            }
        }
    }
}
