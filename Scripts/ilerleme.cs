using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ilerleme : MonoBehaviour
{

     void Start()
    {
        transform.position = new Vector3(-5.46f, -2.74f,0f);
    }


    void Update()
    {

      
    
        float a = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(a, 0f, 0f)*3f*Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown("right"))
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);

        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown("left"))
        {
            transform.eulerAngles = new Vector3(0f, 159.176f, 0f);

        }
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown("up"))
        {
            transform.eulerAngles = new Vector3(0f, 0f, 90f);
        }
        if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown("down"))
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if(transform.position.y <=-61f || transform.position.y >=5f)
        {
            transform.position = new Vector3(-5.46f, -2.74f, 0f); //Yeniden başlatmak yerine konumunu değiştiriyoruz.
        }
        if(transform.position.x <=-11f)
        {
            transform.position = new Vector3(-5.46f, -2.74f, 0f);
        }
    }
}
