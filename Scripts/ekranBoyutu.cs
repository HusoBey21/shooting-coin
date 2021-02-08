using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ekranBoyutu : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer resim;
    [SerializeField]
    private Transform donusum;
    void Start()
    {
        donusum = GameObject.FindGameObjectWithTag("Duvar").transform;
        resim = donusum.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        boyutAyarla();
    }
    public void boyutAyarla()
    {
        donusum.localScale = new Vector3(1f, 1f, 1f);
        float yatayEksen = Camera.main.orthographicSize * 2f*5f;
        float duseyEksen = Screen.height * yatayEksen / Screen.width;
        float resimEni = resim.sprite.bounds.size.x;
        float resimBoyu = resim.sprite.bounds.size.y;
        float x = yatayEksen / resimEni;
        float y = duseyEksen / resimBoyu;

        donusum.localScale = new Vector3(x,y,1f);
     
    }
}
