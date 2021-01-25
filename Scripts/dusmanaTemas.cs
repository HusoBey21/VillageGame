using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmanaTemas : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Hayalet"))
        {
            this.GetComponent<saglik>().canYitir(2f);
            //Hayalete temasta 2 can kaybediyorsun.
            Debug.Log("Düşmana temas edildi");
        }
    }
}
