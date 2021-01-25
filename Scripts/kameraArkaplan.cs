using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraArkaplan : MonoBehaviour
{
    public bool kameraYonu;
    public SpriteRenderer arkaplan;
    void Start()
    {
        arkaplan = GameObject.FindGameObjectWithTag("Köy").GetComponent<SpriteRenderer>();
        boyutBelirle();
    }

    // Update is called once per frame
    void Update()
    {
        boyutBelirle();
        
    }
    public void boyutBelirle()
    {
        Vector3 sagKose = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        float yataysagKose = sagKose.x * 2f/ arkaplan.bounds.size.x; //Orta noktada olduğundan iki ile çarpıyoruz.
        float duseySagKose = sagKose.y * 2f / arkaplan.bounds.size.y;
        if(kameraYonu)
        {
            if(yataysagKose > duseySagKose)
            {
                duseySagKose = yataysagKose;
            }
            else
            {
                yataysagKose = duseySagKose;
            }
            kameraYonu = false;
        }
        kameraYonu = true;
        transform.localScale = new Vector3(yataysagKose,duseySagKose,1f);
    }
}
