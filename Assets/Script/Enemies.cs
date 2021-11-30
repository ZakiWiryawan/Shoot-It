using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    gerak KomponenGerak; // Variabel gerak dan Semua komponennya di Script Gerak
    // Start is called before the first frame update
    void Start()
    {
        KomponenGerak = GameObject.Find("Player").GetComponent<gerak>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Fungsi ketika menyentuh enemies
    void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.tag == "Player")
        {
            KomponenGerak.Heart--;//Mengurangi nilai Heart -1 dst
            KomponenGerak.play_again=true; //player kembali start dari awal
        }
    }
}
