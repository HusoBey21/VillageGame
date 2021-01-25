using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonsuzArkaplan : MonoBehaviour
{
    [SerializeField]
    private float yatayEksen;
    private float mesafe;
    void Start()
    {
        yatayEksen = transform.position.x;
        mesafe = 21.75f;
    }
        

    // Update is called once per frame
    void Update()
    {
        if(yatayEksen + mesafe < Camera.main.transform.position.x)
        {
            sonsuzHareket();
        }
        
    }
    public void sonsuzHareket()
    {
        yatayEksen += mesafe * 2f;
        Vector3 yatayEksenler = new Vector3(yatayEksen, 0f, 0f);
        transform.position = yatayEksenler;

    }
    


}
