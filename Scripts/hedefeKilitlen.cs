using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hedefeKilitlen : MonoBehaviour
{
    [SerializeField]
    
    private int i;
    private Transform yeni;
    private Collider2D carpistirici;
    private GameObject[] mermiler;
    void Start()
    {
        i = Mathf.RoundToInt(Random.Range(0f, 1f));
       
        yeni = GameObject.FindGameObjectWithTag("Cin").transform;
        carpistirici = yeni.GetComponent<BoxCollider2D>();
        mermiler = GameObject.FindGameObjectsWithTag("Meyve");
    }

    // Update is called once per frame
    void Update()
    {
        hedefBul();
    }

    public void hedefBul()
    {
        RaycastHit2D vurus = Physics2D.Raycast(transform.position,transform.forward); //Kendi konumundan ileri konuma doğru gidecek.
        Debug.Log(vurus.transform.name);
        if(vurus.transform !=null)
        {
            if (vurus.collider != null)
            {


                Physics2D.IgnoreCollision(vurus.collider, carpistirici);
                foreach (GameObject mermi in mermiler)
                {
                    if (mermi != null)
                    {


                        Physics2D.IgnoreCollision(vurus.collider, mermi.GetComponent<BoxCollider2D>());
                    }
                }
            }
            
            
                //Yönelimi sağlayacak.
                Vector3 yon = vurus.transform.position - transform.position;
                Rigidbody2D fizik = vurus.transform.GetComponent<Rigidbody2D>();

                fizik.AddForce(yon * 5f);
            
        }
    }
}
