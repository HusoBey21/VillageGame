using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class saglik : MonoBehaviour
{

    [SerializeField]
    private float can;
    private float i;
    private Text metin;
    void Start()
    {
        can = 100f;
        i = 0f;
        metin = GameObject.FindGameObjectWithTag("Metin").GetComponent<Text>();
        metin.text = "Health:" + can.ToString();
        
        
    }
     void Update()
    {
        canKazan();
    }


    public void canYitir(float hasar)
    {
        can -= hasar;
        if(can<=0f)
        {
            SceneManager.LoadScene(1);
            can = 0f;

        }
        metin.text = "Health:" + can.ToString();
    }

    public void canKazan()
    {
        i += Time.deltaTime;
        if(i>=6f)
        {
            can += 4f;
            if(can>=100f)
            {
                can = 100f;
            }
            i = 0f;
            metin.text = "Health:" + can.ToString();
        }
    }
}
