using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraHareketi : MonoBehaviour
{
    public Vector3 anakameraKonumu;
    public Transform donusum;
    void Start()
    {
        anakameraKonumu = Camera.main.transform.position;
        donusum = GameObject.FindGameObjectWithTag("Cin").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 istenenKonum = donusum.position + anakameraKonumu;

        transform.position = Vector3.MoveTowards(transform.position, istenenKonum, 3f * Time.deltaTime);
    }
}
