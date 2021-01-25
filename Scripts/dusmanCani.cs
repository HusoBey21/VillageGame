using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 25 Ocak 2021 Pazartesi
public class dusmanCani : MonoBehaviour
{
    public float can;
    void Start()
    {
        can = 100f;  //100f atamasını gerçekleştirdik.
    }

    

    public void canKaybi(float hasar)
    {
        can -= hasar;
        if(can <=0f)
        {
            gameObject.SetActive(false);
            can = 100f;
        }
        gameObject.SetActive(true);
        Debug.Log("Düşmanın canı ayarlanıyor");
    }
}
