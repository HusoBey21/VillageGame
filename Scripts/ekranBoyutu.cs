using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ekranBoyutu : MonoBehaviour
{
    public SpriteRenderer sprite;
    void Start()
    {
        sprite = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = new Vector3(1f, 1f, 1f);
        float yatayBoyutu = Camera.main.orthographicSize * 2f*5f;
        Debug.Log(yatayBoyutu + ":Kamera buyuklugu");
        float duseyBoyutu = Screen.width * yatayBoyutu / Screen.height;
        float resimEn = sprite.bounds.size.x;
        float resimBoy = sprite.bounds.size.y;
        float enOrani = yatayBoyutu / resimEn;
        Debug.Log(enOrani);
        float boyOrani = duseyBoyutu / resimBoy;
        this.transform.localScale = new Vector3(enOrani, boyOrani,1f);
    }
}
