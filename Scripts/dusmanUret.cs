using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmanUret : MonoBehaviour
{
    [SerializeField]
    private Transform uretilenNesne,anaNesne;
    private GameObject[] oyunNesnesi;
    private float sure;
    public int i;
    void Start()
    {
        oyunNesnesi = GameObject.FindGameObjectsWithTag("Köy");
        uretilenNesne = GameObject.FindGameObjectWithTag("Hayalet").transform;
        anaNesne = GameObject.FindGameObjectWithTag("Cin").transform;
        i = Mathf.RoundToInt(Random.Range(0f,1f));
      
        sure = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        hayaletUret();
    }

    public void hayaletUret()
    {
        sure += Time.deltaTime;  
        if(uretilenNesne !=null)
        {

            if(sure >= 6f)
            {
                
                Transform nesne = Instantiate(uretilenNesne, new Vector3((anaNesne.position.x +3f),(anaNesne.position.y +1f),oyunNesnesi[i].transform.position.z), Quaternion.identity) as Transform;
                Destroy(nesne.gameObject, 6f);
                sure = 0f;
            }
            Debug.Log("Nesne bulundu");
        }

    }
}
