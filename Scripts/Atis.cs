using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atis : MonoBehaviour
{
    [SerializeField]
    private GameObject[] buyuler;
    [SerializeField]
    private int a;
    
    void Start()
    {
        buyuler = GameObject.FindGameObjectsWithTag("Meyve");
        a = 0;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        buyuUret();
    }
    public void buyuUret()
    {
       
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            a += 1;
        }
        if (Input.GetMouseButtonDown(0))
        {
           
            
                if (a < buyuler.Length)
                {
                    if (buyuler[a].transform != null)
                    {
                        Transform y = Instantiate(buyuler[a].transform, transform.position, Quaternion.identity) as Transform;
                        Destroy(y.gameObject, 7f);
                        
                    }
                }
                else
                {
                    a = 0;
                }
            
        }
        
    }

}
