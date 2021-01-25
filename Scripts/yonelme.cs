using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yonelme : MonoBehaviour
{
    [SerializeField]
   
    private Vector3 nereyeDogru;
    [SerializeField]
    private GameObject oyuncu;
  
    void Start()
    {
     
        oyuncu = GameObject.FindGameObjectWithTag("Cin");
       
    }

    // Update is called once per frame
    void Update()
    {
        yonelim();
    }
    public void yonelim()
    {
            nereyeDogru = Input.mousePosition;
        if (oyuncu != null)
        {


            if (Vector3.Distance(transform.position, oyuncu.transform.position) > 1f)
            {
                transform.position = Vector3.MoveTowards(transform.position, nereyeDogru, 3f * Time.deltaTime);

            }
        }
           
            
       
    }
    
}
