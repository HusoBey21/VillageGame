using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmanTespiti : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Hayalet"))
        {
            collision.gameObject.GetComponent<dusmanCani>().canKaybi(3f);
        }
    }
}
