using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solaDogru : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * 3f * Time.deltaTime;  //Sola doğru ilerleme
    }
}
